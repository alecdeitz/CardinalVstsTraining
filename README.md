# Cardinal VSTS Training

### Create a new VSTS Team Project
1. Click the Azure DevOps icon in the top left corner to get to your top level of projects
2. Click "Create Project"
3. Click the "Advanced" button
4. Change the Work Item Process to "Scrum" 
5. Quick discussion on the different types

### Create a Git Repository
1. Open your new Team Project
2. Go to Repos
3. A Git Repo is already created for you, but we'll create a new one for training
4. At the top of the screen click the arrow next to your currently open repo
5. Click Import Repository
6. Use this url - https://github.com/alecdeitz/CardinalVstsTraining
7. Quick discussion on Git vs TFVC

### Setup Build Agent
1. Create a VM (or use your local machine) - Visual Studio Enterprise 2017 on Windows 10 Enterprise N (x64)
 with 8GB of RAM recommended (You will need at least some form of Visual Studio installed)
2. Login to your VSTS account from the machine
3. Go to "Organization Settings"
4. Go to "Agent Pools"
5. Click "Download Agent"
6. Extract the files to somewhere on your computer
7. Run the "config" file and follow the instructions
8. Run the "run" file once you've completed
#### To Generate a PAT (Personal Access Token)
1. Click your account in the top right-hand corner
2. Go to the "Personal Access Tokens" section
3. Add a new token and give it access to "All Scopes"
4. Save the token somewhere, you'll only be able to see it once

### Create a Build for the project
1. Pull the project down from source onto your local computer (this will be necessary for later)
2. Make sure it builds locally
3. Go to your VSTS, go to Pipelines, Builds, and then add a new build
4. Select "Azure Repos Git" as your Source Control provider and choose CardinalVstsTraining
5. Choose the ASP.NET template
6. Make sure the Solution's build arguments look like this:

/p:DeployOnBuild=true /p:WebPublishMethod=Package /p:PackageAsSingleFile=true /p:SkipInvalidConfigurations=true /p:PackageLocation="$(build.artifactstagingdirectory)"

7. Queue a build and use the "Default" agent pool that we setup our agent on

### Create a Release to go with the Build
1. Go to the Releases tab and click the "+" button
2. Choose "Create a release pipeline"
3. Choose the "Azure App Service deployment" template
4. Click "Add an artifact" and choose the previous build you created
5. Click the environment name "Stage 1" and rename it to something like "Dev"
6. Click the lightning symbol next to the left of the environment's name (should be called "Pre-deployment Conditions")
7. Make sure the trigger is set to "After Release". This is how you can customize the triggers for your different environments
8. Click the "1 job, 1 task" link
9. Fill out the information for an app service on your Azure subscription (you may need to link your Azure subscription to your VSTS instance which you should be able to do from the "Manage" link, also create an App Service if you haven't already)

### Tests in VSTS
1. Go to the "Test Plans" tab and make sure you have the ability to add/manage tests
2. If so, create a new Test Plan
3. Try running the tests locally (You'll need the Specflow extension installed in your Visual Studio instance)
4. Run the follow command to import your tests into VSTS:

5. Go back to your test plan and click "Add Existing"
6. Search for your imported test cases, should be the latest created and then add them to your test plan
6. Create a build for the Acceptance Tests project (should be able to use a standard ASP.NET project again)
7. Make sure the build arguments for the solution look like this:

/p:TargetProfile=$(BuildConfiguration)/p:DeployOnBuild=true /p:WebPublishMethod=Package /p:PackageAsSingleFile=true /p:SkipInvalidConfigurations=true /p:PackageLocation=$(Build.StagingDirectory)

8. Go to create a release and have it as a blank release
9. Add a "Visual Studio Test" task
10. Set the "Select Tests Using" to "Test Run"
11. "Test run" to "$(test.RunId)"
12. "Search Folder" to "$(System.DefaultWorkingDirectory)"
13. Go back to your test plan and click the arrow right next to the name of your test plan then click "Test Plan Settings"
14. Set the build and release pipelines to the one you just created. Put "Build Number" to latest and "Stage" to your environment name
15. Run the tests by right clicking on any of them and selecting "Run tests"
16. Quick discussion on the rest of the Test tab
