﻿using FootballTeamGenerator.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator.Models
{
    public class Stat
    {
        private const int MIN_STAT_VALUE = 0;
        private const int MAX_STAT_VALUE = 100;

        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;


        public Stat(int endurance,int sprint,int dribble,int passing,int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }
        
        public int Shooting
        {
            get { return this.shooting; }
            private set
            {
                if (value < 0 || value > 100)
                {
                    ValidateStat(value,nameof(this.Shooting));
                }
                this.shooting = value;
            }
        }

        public int Passing
        {
            get { return this.passing; }
            private set
            {
                if (value < 0 || value > 100)
                {
                    if (value < 0 || value > 100)
                    {
                        ValidateStat(value, nameof(this.Passing));
                    }
                }
                this.passing = value;
            }
        }

        public int Dribble
        {
            get { return this.dribble; }
            private set
            {
                if (value < 0 || value > 100)
                {
                    if (value < 0 || value > 100)
                    {
                        ValidateStat(value, nameof(this.Dribble));
                    }
                }
                this.dribble = value;
            }
        }

        public int Sprint
        {
            get { return this.sprint; }
            private set
            {
                if (value < 0 || value > 100)
                {
                    if (value < 0 || value > 100)
                    {
                        ValidateStat(value, nameof(this.Sprint));
                    }
                }
                this.sprint = value;
            }
        }

        public int Endurance
        {
            get { return this.endurance; }
            private set
            {
                if (value < 0 || value > 100)
                {
                    if (value < 0 || value > 100)
                    {
                        ValidateStat(value, nameof(this.Endurance));
                    }
                }
                this.endurance = value;
            }
        }
        public double OverallStat()
        {
            return (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0;
        }
        private void ValidateStat(int value ,string name)
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InvalidStatException
                    ,name,MIN_STAT_VALUE,MAX_STAT_VALUE));
            }
        }

    }
}
