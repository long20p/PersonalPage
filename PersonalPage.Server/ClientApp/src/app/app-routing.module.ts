import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BlogComponent } from './blog/blog.component';
import { MainPageComponent } from './main-page.component';
import { ArticlesComponent } from './blog/articles/articles.component';
import { ArticleDetailComponent } from './blog/article-detail/article-detail.component';

const routes: Routes = [
  { path: '', component: MainPageComponent },
  { 
    path: 'blog', 
    component: BlogComponent, 
    children: [
      { path: '', redirectTo: 'articles', pathMatch: 'prefix' },
      { path: 'articles', component: ArticlesComponent },
      { path: 'article/:articleId', component: ArticleDetailComponent }
    ]
  },
  { path: '**', redirectTo: '', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
