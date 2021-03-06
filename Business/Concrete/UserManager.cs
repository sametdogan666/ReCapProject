using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Business.BusinessAspect.Autofac;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public IDataResult<User> GetById(int userId)
        {
            var getById = _userDal.Get(u => u.Id == userId);
            return new SuccessDataResult<User>(getById);
        }

        [ValidationAspect(typeof(UserValidator))]
        [SecuredOperation("admin")]
        public void Add(User user)
        {
            _userDal.Add(user);

        }

        [SecuredOperation("admin")]
        [ValidationAspect(typeof(UserValidator))]
        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }

        [ValidationAspect(typeof(UserValidator))]
        [SecuredOperation("admin")]
        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public IDataResult<List<User>> GetAll()
        {
            var getAll = _userDal.GetAll();
            return new SuccessDataResult<List<User>>(getAll);
        }
    }
}
