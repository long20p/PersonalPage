﻿using PersonalPage.Persistence.Models;
using PersonalPage.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalPage.Server.Services
{
    public class ArticleService : IArticleService
    {
        private IArticleRepository articleRepository;

        public ArticleService(IArticleRepository repository)
        {
            articleRepository = repository;
        }

        public async Task<IEnumerable<Article>> GetAllArticles()
        {
            return await articleRepository.GetAll();
        }
    }
}