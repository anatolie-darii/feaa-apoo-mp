import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TaskListComponent } from './task-list/task-list.component';

const routes: Routes = [
  {
    path: "tasks",
    children: [
      {
        path: "list",
        component: TaskListComponent
      },
      {
        path: "",
        redirectTo: "list",
        pathMatch: "full"
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TasksRoutingModule { }
