﻿using CarsSystem.Data.Models;
using CarsSystem.Data.Repositories;
using CarsSystem.Services.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSystem.Services.Data
{
    public class UsersService : IUsersService
    {
        private readonly IRepository<User> userRepo;

        public UsersService(IRepository<User> userRepo)
        {
            if (userRepo == null)
            {
                throw new ArgumentException("The user repo shold not be null!");
            }

            this.userRepo = userRepo;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return this.userRepo.All();
        }

        public User GetUserById(string id)
        {
            return this.userRepo.GetById(id);
        }

        public IEnumerable<User> GetUserByEGN(long egn)
        {
            return this.userRepo.All()
                                .Where(u => u.EGN == egn);
        }

        public string GetUserId(Car car)
        {
            var result = this.GetAllUsers()
                             .FirstOrDefault(u => u.Id == car.UserId);

            return result.Id;
        }
    }
}
