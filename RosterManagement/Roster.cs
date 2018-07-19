using System;
using System.Linq;
using System.Collections.Generic;

namespace RosterManagement
{
    public class CodeSchool
    {
        Dictionary<int, List<string>> _roster;

        public CodeSchool()
        {
            _roster = new Dictionary<int, List<String>>();
        }
        
        /// <summary>
        /// Should be able to Add Student to a Particular Wave
        /// </summary>
        /// <param name="cadet">Refers to the name of the Cadet</param>
        /// <param name="wave">Refers to the Wave number</param>
        public void Add(string cadet, int wave)
        {
            try
            {
                _roster[wave].Add(cadet);
                _roster[wave].Sort();
            } 
            catch(Exception e)
            {
                List<string> temp = new List<string>();
                temp.Add(cadet);
                _roster.Add(wave, temp);
            }
        }

        /// <summary>
        /// Returns all the Cadets in a given wave
        /// </summary>
        /// <param name="wave">Refers to the wave number from where cadet list is to be fetched</param>
        /// <returns>List of Cadet's Name</returns>
        public List<string> Grade(int wave)
        {
            try
            {
                List<string> CadetsInAGivenWave = _roster[wave];
                return CadetsInAGivenWave;
            }
            catch(Exception e)
            {
                return new List<string>();
            }
            
        }

        /// <summary>
        /// Return all the cadets in the CodeSchool
        /// </summary>
        /// <returns>List of Cadet's Name</returns>
        public List<string> Roster()
        {
            var cadets = new List<string>();
            SortedDictionary<int, List<string>> roster= new SortedDictionary<int, List<string>>(_roster);
            foreach(List<string> s in roster.Values)
            {
                    cadets.AddRange(s);
            }
            return cadets;
        }
    }
}
