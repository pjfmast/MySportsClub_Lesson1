﻿using MySportsClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySportsClub.Data {
    public interface IWorkoutRepository {

        IEnumerable<Workout> AllWorkouts { get; }

    }
}
