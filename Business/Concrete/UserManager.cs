﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager: IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal=userDal;
        }

        public void Add(User user)
        {
          _userDal.Add(user);
        }

        public void Delete(User user)
        {
           _userDal.Delete(user);
        }

        public User GetId(int id)
        {
            return _userDal.Get(id);
        }

        public List<User> GetList()
        {
            return _userDal.GetList();
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }
    }
}
