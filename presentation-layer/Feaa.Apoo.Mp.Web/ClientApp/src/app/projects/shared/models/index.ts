export enum ProjectType {
  Books,
  Buildings
}

export enum ExecutionState {
  Initial,
  InProgress,
  Canceled,
  Finished
}

export interface Task {
  state: ExecutionState;
}

export interface Client {
  id: string;
  name: string;
  address: string;
}

export interface Project {
  id: string;
  name: string;
  type: ProjectType;
  state: ExecutionState;
  startDate: Date;
  endDate?: Date;
  client: Client;

  tasks: Task[];
}
