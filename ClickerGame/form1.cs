using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class form1 : Form
    {
        //Timer setups
        private readonly Timer _timer = new Timer();
        private readonly Timer _timer2 = new Timer();
        private readonly Timer _ritualTimer = new Timer();
        //initial variables
        double favour = 0;
        double favourPerSecond = 0;
        double ritualFavour = 10;
        int ritualLength = 10;
        int ritualCounter = 0;
        //list of upgrade costs
        double _costofOne = 10;
        double _costofThree = 5000;
        //list of upgrade purchase counters
        int _numofOne = 0;
        int _numofTwo = 0;
        int _numofThree = 0;
        //initialise upgrade effect
        double _effectofOne = 0;
        double _effectofTwo = 0;
        double _effectofThree = 0;
        //Sacrifice reward status
        bool _rewOne = false;
        bool _rewTwo = false;
        bool _rewThree = false;
        bool _rewFour = false;
        double _upgradesOne = 0;
        double _upgradesTwo = 0;
        double _upgradesThree = 0;
        //workstation status setup
        int _workinOne = 0;
        int _spaceinOne = 0;
        double _spacecostofOne = 100;
        public form1()
        {
            InitializeComponent();
            //Timer to add favour from income sources every second
            _timer2.Interval = 1000;
            _timer2.Tick += UpdateFavour;
            _timer2.Enabled = true;
            //Timer to update UI details
            _timer.Interval = 1;
            _timer.Tick += UpdateFields;
            _timer.Enabled = true;
            //set clickingobject color to green
            clickingObject.BackColor = Color.Green;
        }
        void UpdateFavour(object sender, EventArgs e)
        {
            //update upgrade effects
            _effectofOne = _numofOne * (0.5 + _upgradesOne);
            _effectofTwo = _numofTwo * (1 + _upgradesTwo);
            _effectofThree = _numofThree * (15 + _upgradesThree);
            //Keeps track of total favour per second from ALL sources
            favourPerSecond = (_effectofOne + _effectofTwo + _effectofThree);
            //Adds favourPerSecond to favour
            favour += favourPerSecond;
            //Removes unnecessary decimal places
            Math.Round(favour, 1);
        }
        void UpdateFields(object sender, EventArgs e)
        {
            //cultist sacrifice reward condition checker
            if (!_rewOne && _numofTwo >= 10)
            {
                _rewOne = true;
                ritualFavour += 20;

            }
            if(!_rewTwo && _numofTwo >= 15)
            {
                _rewTwo = true;
                _upgradesOne = 1;

            }
            if(!_rewThree && _numofTwo >= 25)
            {
                _rewThree = true;
                ritualFavour += 100;
            }
            if(!_rewFour && _numofTwo >= 40)
            {
                _rewFour = true;
                _upgradesThree = 15;
            //Show if player can afford upgrades
            if(favour >= _costofOne)
            {
                upgrade1.BackColor = Color.Green;
            } else
            {
                upgrade1.BackColor = Color.Empty;
            }
            if (_numofOne >= 1)
            {
                upgrade2.BackColor = Color.Green;
            }
            else
            {
                upgrade2.BackColor = Color.Empty;
            }
            if (favour >= _costofThree)
            {
                upgrade3.BackColor = Color.Green;
            }
            else
            {
                upgrade3.BackColor = Color.Empty;
            }
            //Show if player can afford workstations.
            if(favour >= _spacecostofOne)
            {
                addcap1.BackColor = Color.Green;
            }
            else
            {
                addcap1.BackColor = Color.Empty;
            }
            }
            //FAVOUR STATS
            //Holds information relating to favour
            currencyDisplay.Text = ($"Eldritch Favour: {favour} \nFavour Per Second: {favourPerSecond} \nFavour per ritual: {ritualFavour}\n");
            //Display upgrade box texts
            upgrade1.Text = ($"{_numofOne} owned \nEnlist Cultist: {_costofOne} favour \nfavour per second: {(0.5 + _upgradesOne)}");
            upgrade2.Text = ($"Cultist Sacrificed: {_numofTwo} \nSacrice Cultist? \nfavour per ritual: + 1");
            upgrade3.Text = ($"Shoggoths summoned: {_numofThree} \nSummon Shogoth: {_costofThree} favour \nfavour per second: {10 + _upgradesThree}");
            //Workstation texts
            station1.Text = ($"Ritual Altar: Removes time from the ritual \nWorkers: {_workinOne} Space: {_spaceinOne}");
            addcap1.Text = ($"Add Space: {_spacecostofOne}");

        }

        private void ritualBox_Click(object sender, EventArgs e)
        {
            //begin ritual process
            if (!_ritualTimer.Enabled)
            {
                clickingObject.BackColor = Color.Empty;
                //setup counter
                ritualCounter = ritualLength;
                //Ritual timer stopwatch
                _ritualTimer.Interval = 1000;
                clickingObject.Text = ("Starting Ritual");
                _ritualTimer.Tick += completeRitual;
                _ritualTimer.Enabled = true;
            }
        }
        private void completeRitual(object sender, EventArgs e)
        {
            //if ritual is complete
            if(ritualCounter <= 0)
            {
                clickingObject.BackColor = Color.Green;
                _ritualTimer.Tick -= completeRitual;
                _ritualTimer.Enabled = false;
                clickingObject.Text = ("Perform Ritual");
                favour += ritualFavour;
            }
            else if (_ritualTimer.Enabled)
            {
                clickingObject.BackColor = Color.Empty;
                clickingObject.Text = ($"Performing Ritual: {ritualCounter}");
                ritualCounter--;
            }
        }
        private void upgradeOne_Click(object sender, EventArgs e)
        {
            if(favour >= _costofOne)
            {
                favour -= _costofOne;
                //Make upgrade cost more favour
                _costofOne = Math.Ceiling(_costofOne * 1.5);
                _numofOne++;
            } 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //if player has a cultist add 1 to cultists sacrificed
            if(_numofOne >= 1)
            {
                ritualFavour += 1;
                _numofOne--;
                _numofTwo++;
            }
        }

        private void upgrade3_Click(object sender, EventArgs e)
        {
            if (favour >= _costofThree)
            {
                favour -= _costofThree;
                //Make upgrade cost more favour
                _costofThree = Math.Ceiling(_costofThree * 1.5);
                _numofThree++;
            }
        }
        //Click functions to add workers to stations.
        //Workstation 1, ritual is shorter for each worker
        private void button1_Click_2(object sender, EventArgs e)
        {
            if(_numofOne >= 1 && _workinOne < _spaceinOne)
            {
                ritualLength--;
                _workinOne++;
                _numofOne--;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(_workinOne >= 1)
            {
                ritualLength++;
                _workinOne--;
                _numofOne++;
            }
        }

        private void addcap1_Click(object sender, EventArgs e)
        {
            if(favour >= _spacecostofOne){
                favour -= _spacecostofOne;
                _spacecostofOne = Math.Ceiling(_spacecostofOne * 2);
                _spaceinOne++;
            }
        }

        private void reward2_Click(object sender, EventArgs e)
        {

        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //Workstation 2
    }
}