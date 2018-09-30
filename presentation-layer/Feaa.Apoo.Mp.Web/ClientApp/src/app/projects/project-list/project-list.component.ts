import { Component, OnInit, ViewChild } from "@angular/core";
import { MatTableDataSource, MatSort, MatPaginator } from "@angular/material";
import { Router, ActivatedRoute } from "@angular/router";
import { ProjectsService } from "../shared/projects.service";
import { Project, ProjectType, ExecutionState } from "../shared/models";

@Component({
  selector: "mp-project-list",
  templateUrl: "./project-list.component.html",
  styleUrls: ["./project-list.component.css"]
})
export class ProjectListComponent implements OnInit {
  displayedColumns: string[] = ["name", "type", "state", "startDate"];
  dataSource: MatTableDataSource<Project>;

  typeEnum = ProjectType;
  stateEnum = ExecutionState;
  
  @ViewChild(MatSort)
  sort: MatSort;

  @ViewChild(MatPaginator)
  paginator: MatPaginator;

  constructor(
    private readonly router: Router,
    private readonly route: ActivatedRoute,
    private readonly service: ProjectsService
  ) {}

  ngOnInit() {
    this.service.getProjects().subscribe(projects => {
      this.dataSource = new MatTableDataSource<Project>(projects);
      this.dataSource.sort = this.sort;
      this.dataSource.paginator = this.paginator;
    });
  }

  openProjectDetails(event: Event, project: Project) {
    this.router.navigate([project.id], { relativeTo: this.route });
  }
}
