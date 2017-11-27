using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_TimeEngine.TimeEngine
{
    /// <summary>
    /// Class that keeps track of the Ingame time.
    /// Allows you to advance time by a specified amount.
    /// </summary>
    public class GameTime
    {
        public DateTime IngameTime { get; }

        /// <summary>
        /// Constructor for the InGame Time
        /// </summary>
        /// <param name="StartTime">Starting Time of the Game</param>
        public GameTime(DateTime startTime)
        {
            IngameTime = startTime;
        }

        /// <summary>
        /// Advances the gametime for x Seconds
        /// </summary>
        /// <param name="secondsToAdd">Amound of seconds to progress</param>
        /// <returns>Gametime after function call</returns>
        public DateTime AdvanceTimeInSeconds(int secondsToAdd)
        {
            IngameTime.AddSeconds(secondsToAdd);
            return IngameTime;
        }

        /// <summary>
        /// Advances the gametime for x Hours
        /// </summary>
        /// <param name="hoursToAdd">Amound of hours to progress</param>
        /// <returns></returns>
        public DateTime AdvanceTimeInHours(int hoursToAdd)
        {
            IngameTime.AddHours(hoursToAdd);
            return IngameTime;
        }

        /// <summary>
        /// Advances the gametime for x Days
        /// </summary>
        /// <param name="daysToAdd">Amound of days to progress</param>
        /// <returns></returns>
        public DateTime AdvanceTimeInDays(int daysToAdd)
        {
            IngameTime.AddDays(daysToAdd);
            return IngameTime;
        }
    }
}
