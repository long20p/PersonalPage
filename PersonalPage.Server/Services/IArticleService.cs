using PersonalPage.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalPage.Server.Services
{
    public interface IArticleService
    {
        Task<IEnumerable<Article>> GetAllArticles();
    }
}
