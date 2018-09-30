import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { ProjectListComponent } from "./project-list/project-list.component";
import { ProjectDetailsComponent } from "./project-details/project-details.component";

const routes: Routes = [
  {
    path: "projects",
    children: [
      {
        path: "",
        component: ProjectListComponent
      },
      {
        path: ":id",
        component: ProjectDetailsComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ProjectsRoutingModule {}
