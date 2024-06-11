using BankAppAPI.Data;
using BankAppAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BankAppAPI.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public User CreateUser(User newUser)
        {
            // Add the new user to the database
            _context.Users.Add(newUser);
            _context.SaveChanges();
            return newUser;
        }

        public User DeleteUser(int id)
        {
            // Find the user by ID
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return null; // User not found
            }

            // Remove the user from the database
            _context.Users.Remove(user);
            _context.SaveChanges();
            return user;
        }

        public User GetUserById(int id)
        {
            // Find the user by ID
            return _context.Users.Find(id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            // Retrieve all users from the database
            return _context.Users.ToList();
        }

        public User UpdateUser(int id, User updatedUser)
        {
            // Find the user by ID
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return null; // User not found
            }

            // Update user properties
            user.Username = updatedUser.Username;
            user.Email = updatedUser.Email;
            // Update other properties as needed

            // Save changes to the database
            _context.SaveChanges();
            return user;
        }
    }
}
