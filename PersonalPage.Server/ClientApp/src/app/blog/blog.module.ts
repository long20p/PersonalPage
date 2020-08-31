import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { BlogComponent } from './blog.component';
import { ArticlesComponent } from './articles.component';
import { ArticleDetailComponent } from './article-detail.component';

@NgModule({
  declarations: [
    BlogComponent,
    ArticlesComponent,
    ArticleDetailComponent
  ],
  imports: [
    CommonModule,
    RouterModule
  ]
})
export class BlogModule { }
