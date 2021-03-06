﻿using System;
using System.ComponentModel.DataAnnotations;

namespace FilmoweJanusze.Infrastructure
{
    public class CheckBirthday : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime = Convert.ToDateTime(value);

            if (dateTime <= DateTime.Today)
                return true;
            else
                return false;
        }
    }
}