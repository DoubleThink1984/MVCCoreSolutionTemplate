using Sandbox.DataLayer;
using Sandbox.Models;
using Sandbox.Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Repository.RepositoryImplementations
{
    public class QuestionRepository : GenericRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Question Get(int questionId)
        {
            var query = GetAll().FirstOrDefault(b => b.Id == questionId);
            return query;
        }

        public async Task<Question> GetSingleAsyn(int questionId)
        {
            return await _context.Set<Question>().FindAsync(questionId);
        }

        public override Question Update(Question question, object key)
        {
            Question exist = _context.Set<Question>().Find(key);
            if (exist != null)
            {
                //question.CreatedBy = exist.CreatedBy;
                //question.CreatedOn = exist.CreatedOn;
            }
            return base.Update(question, key);
        }

        public async override Task<Question> UpdateAsyn(Question question, object key)
        {
            Question exist = await _context.Set<Question>().FindAsync(key);
            if (exist != null)
            {
                //question.CreatedBy = exist.CreatedBy;
                //question.CreatedOn = exist.CreatedOn;
            }
            return await base.UpdateAsyn(question, key);
        }
    }
}
