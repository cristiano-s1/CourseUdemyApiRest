﻿using Udemy.Api.Models;
using Udemy.Api.Repository.Generic;

namespace Udemy.Api.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;

        public PersonBusinessImplementation(IRepository<Person> repository)
        {
            _repository = repository;
        }

        public List<Person> GetAll()
        {
            return _repository.GetAll();
        }

        public Person GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Person Insert(Person entity)
        {
            return _repository.Insert(entity);
        }

        public Person Update(Person entity)
        {
            return _repository.Update(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
