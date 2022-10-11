﻿namespace BumboPOC.Models
{
    public class PrognosisDepartment
    {
        public Department department { get; set; }

        // amount of man hours that must be worked on this day
        public int MinutesToBeScheduled { get; set; }

        // constructor 
        public PrognosisDepartment(Department department, int hoursToBeScheduled)
        {
            this.department = department;
            MinutesToBeScheduled = hoursToBeScheduled;
        }


    }
}