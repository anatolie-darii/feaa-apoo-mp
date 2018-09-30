import { Injectable } from "@angular/core";
import { ProjectType, Project, ExecutionState } from "./models";
import { Observable, of } from "rxjs";

const ELEMENT_DATA: Project[] = [
  {
    id: "p1",
    name: "Project 1",
    type: ProjectType.Books,
    state: ExecutionState.Initial,
    startDate: new Date(2018, 0, 15),
    client: {
      id: "c1",
      name: "Client 1",
      address: "Some random address"
    },
    tasks: []
  },
  {
    id: "p2",
    name: "Project 2",
    type: ProjectType.Books,
    state: ExecutionState.InProgress,
    startDate: new Date(2018, 5, 16),
    client: {
      id: "c1",
      name: "Client 1",
      address: "Some random address"
    },
    tasks: []
  },
  {
    id: "p3",
    name: "Project 3",
    type: ProjectType.Buildings,
    state: ExecutionState.Initial,
    startDate: new Date(2018, 2, 25),
    client: {
      id: "c1",
      name: "Client 1",
      address: "Some random address"
    },
    tasks: []
  },
  {
    id: "p4",
    name: "Project 4",
    type: ProjectType.Books,
    state: ExecutionState.Initial,
    startDate: new Date(2018, 9, 15),
    client: {
      id: "c1",
      name: "Client 1",
      address: "Some random address"
    },
    tasks: []
  }
];

@Injectable({
  providedIn: "root"
})
export class ProjectsService {
  constructor() {}

  getProjects(): Observable<Project[]> {
    return of(ELEMENT_DATA);
  }

  getProject(id: string): Observable<Project> {
    return of(ELEMENT_DATA.find(p => p.id === id));
  }
}
