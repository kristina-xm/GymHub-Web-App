﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymHub.Web.ViewModels.User
{
    public class RegisteredTrainerViewModel
    {
        public string Bio { get; set; } = null!;

        public int Experience { get; set; }

    }
}
