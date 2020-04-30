﻿using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) //it works when Constructer, new 
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.Firstname + " mask is given.");
            }
            else
            {
                Console.WriteLine(person.Firstname + " no mask...");
            }
        }
    }
}
