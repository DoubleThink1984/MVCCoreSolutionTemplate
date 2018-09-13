using Sandbox.Models;
using Sandbox.Repository.RepositoryInterfaces;
using Sandbox.Services.Dtos;
using Sandbox.Services.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sandbox.Services.ServiceImplementations
{
    public class QuestionService : IQuestionService
    {
        private IQuestionRepository _questionRepository;

        public QuestionService(IQuestionRepository questionRepository)
        {
            this._questionRepository = questionRepository;
        }

        public QuestionDto Get(int id)
        {
            var asdf = _questionRepository.Get(id);
            return new QuestionDto { Id = asdf.Id};
        }

        public IEnumerable<QuestionDto> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
