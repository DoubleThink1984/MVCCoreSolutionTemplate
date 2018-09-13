using Sandbox.Models;
using Sandbox.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sandbox.Services.ServiceInterfaces
{
    public interface IQuestionService : IGenericService<QuestionDto, int>
    {
    }
}
