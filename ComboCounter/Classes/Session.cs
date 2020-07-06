﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboCounter.Classes
{
    /// <summary>
    /// Provides a container for the record of forces and timing between forces
    /// for a workout session. Both the force and the time have to be inserted
    /// at the same time they cannot be inserted independently.
    /// </summary>
    class Session
    {

        public DateTime StartDate { get; private set; }

        /// <summary>
        /// This list contains the forces gathered from the sensor
        /// They correspond with a timestamp in the time list
        /// </summary>
        public List<double> Forces { get; private set; }

        // This list represents the timestamp for each of the forces
        // It contains how long since the startdate the force measurement took place
        // Useful to determine the time between hits of the bag
        public List<double> Times { get; private set; }

        public int SessionID { get; set; }


        /// <summary>
        /// Adds a record to both the forces and the time list
        /// </summary>
        /// <param name="force">The force to be inserted</param>
        /// <param name="time">The time to be inserted. This time is the time from the startdate</param>
        public void insertHit(double force, double time)
        {
            Forces.Add(force);
            Times.Add(time);
        }

        /// <summary>
        /// Initializes a session with a start date to use as an
        /// identifier in the DB later on. Is also is a reference point for
        /// the times listed in the time list.
        /// </summary>
        /// <param name="start">The time and date from when the session starts</param>
        public Session(DateTime start)
        {
            StartDate = start;
            Forces = new List<double>();
            Times = new List<double>();
        }

        public Session(DateTime start, int ID) 
            : this(start)
        {
            SessionID = ID;
        }


        /// <summary>
        /// Allows the Session to be used in a combo box and have the date be what is represented
        /// </summary>
        /// <returns></returns>
        override public string ToString()
        {
            return StartDate.ToString();
        }

        /// <summary>
        /// Gives an easy ability to show the total force for the session
        /// </summary>
        /// <returns>The sum of the force array</returns>
        public double TotalForce => Forces.Sum<Double>(x => x);

        /// <summary>
        /// Gives easy access to deliver the average force over the course
        /// of the session
        /// </summary>
        /// <returns>The average of all the forces</returns>
        public double AvgForce => Forces.Average();


        //public double MaxForce() => Forces.Max();

        public double MaxForce => Forces.Max();

        public double AverageTime 
        {
            get
            {
                double lastTime = 0.0;
                double sum = 0.0;

                if (Times.Count == 0)
                {
                    return 0.0;
                }

                foreach (var time in Times)
                {
                    sum += (time - lastTime);
                    lastTime = time;
                }

                return sum / Times.Count;
            }

        }

        public double ShortestTime
        {

            get
            {
                double smallestTime = 0.0;
                double lastTime = 0.0;

                foreach (var time in Times)
                {
                    if ((time - lastTime) < smallestTime)
                    {
                        smallestTime = time - lastTime;
                    }
                    lastTime = time;
                }

                return smallestTime;

            }
        }
    
    }
}
