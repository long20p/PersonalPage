import { Component, OnInit } from '@angular/core';
import { ArticlesService } from '../articles.service';

@Component({
  selector: 'app-articles',
  templateUrl: './articles.component.html',
  styleUrls: ['./articles.component.scss']
})
export class ArticlesComponent implements OnInit {

  articles: ArticleBrief[];
  error: string;

  constructor(private articleService: ArticlesService)
  {
  }

  ngOnInit() {
    this.articleService.getArticles().subscribe({
      next: articles => this.articles = articles,
      error: message => this.error = message
    });
  }

}
