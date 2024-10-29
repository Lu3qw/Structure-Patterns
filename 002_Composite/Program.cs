// Composite (компонувальник)

// Організовує деревовидну структруру 






using _002_Composite;


//Component root = new Composite("Root");

//Component branch1 = new Composite("branch1");
//Component branch2 = new Composite("branch2");

//Component leaf1 = new Leaf("leaf1");
//Component leaf2 = new Leaf("leaf2");
//Component leaf3 = new Leaf("leaf3");
//Component leaf4 = new Leaf("leaf4");

//root.Add(branch1);
//root.Add(branch2);

//branch1.Add(leaf1);
//branch1.Add(leaf2);
//branch2.Add(leaf3);
//branch2.Add(leaf4);

//root.Operation();

Component File = new Composite("File");

Component New = new Composite("New");
Component Project = new Leaf("Project...");
Component Repository = new Leaf("Repository...");
Component FileLeaf = new Leaf("File...");

Component Open = new Composite("Open");
Component ProjectSolution = new Leaf("Project/Solution...");
Component Folder = new Leaf("Folder...");
Component WorkSpace = new Leaf("WorkSpace...");

Component CloneRepository = new Composite("Clone Repository...");
Component StartWindow = new Composite("Start Window");
Component AddToSource = new Composite("Add to Source Control");


File.Add(New);
File.Add(Open);
File.Add(CloneRepository);
File.Add(StartWindow);
File.Add(AddToSource);

New.Add(Project);
New.Add(Repository);
New.Add(FileLeaf);

Open.Add(ProjectSolution);
Open.Add(Folder);
Open.Add(WorkSpace);

File.Operation();