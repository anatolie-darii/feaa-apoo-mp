import { Component, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { ProjectsService } from "../shared/projects.service";
import { Project, ProjectType, ExecutionState } from "../shared/models";

@Component({
  selector: "mp-project-details",
  templateUrl: "./project-details.component.html",
  styleUrls: ["./project-details.component.css"]
})
export class ProjectDetailsComponent implements OnInit {
  project: Project;

  projectTypeEnum = ProjectType;
  projectTypes: ProjectType[] = [ProjectType.Books, ProjectType.Buildings];
  
  executionStateEnum = ExecutionState;
  executionStates: ExecutionState[] = [ExecutionState.Initial, ExecutionState.InProgress, ExecutionState.Canceled, ExecutionState.Finished];

  constructor(
    private readonly route: ActivatedRoute,
    private readonly service: ProjectsService
  ) {}

  ngOnInit() {
    this.route.paramMap.subscribe(map => {
      this.service.getProject(map.get("id")).subscribe(project => {
        this.project = project;
      });
    });
  }
}
