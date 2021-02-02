using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MySportsClub.Data;
using Newtonsoft.Json;

namespace MySportsClub.Models
{
    public class JsonWorkoutRepository : IWorkoutRepository
    {
        IQueryable<Workout> IWorkoutRepository.AllWorkouts
            => LoadJson().AsQueryable();


        public IQueryable<Workout> EnrolledWorkouts(int id)
        {
            throw new NotImplementedException();
        }

        private IList<Workout> LoadJson()
        {
            using (StreamReader r = new StreamReader("Workouts.json"))
            {
                string json = r.ReadToEnd();
                List<Workout> items = JsonConvert.DeserializeObject<List<Workout>>(json);
                return items;
            }
        }
    }
}
