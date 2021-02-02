using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySportsClub.Data;
using MySportsClub.Infrastructure;

namespace MySportsClub.Models {
    public class FakeWorkoutRepository : IWorkoutRepository {
        public IQueryable<Workout> AllWorkouts => new List<Workout> {
            new Workout {
                Id = 1,
                Title = "Yin Yoga",
                Capacity = 15,
                StartTime = DateTime.Now.NextDayAt(DayOfWeek.Monday, 9, 15),
                EndTime = DateTime.Now.NextDayAt(DayOfWeek.Monday, 10, 15)
            },
            new Workout {
                Id = 2,
                Title = "Club power",
                Capacity = 20,
                StartTime = DateTime.Now.NextDayAt(DayOfWeek.Saturday, 10, 0),
                EndTime = DateTime.Now.NextDayAt(DayOfWeek.Saturday, 10, 45)
            }
        }.AsQueryable<Workout>();

        public IQueryable<Workout> EnrolledWorkouts(int id) {
            throw new NotImplementedException();
        }
    }
}
