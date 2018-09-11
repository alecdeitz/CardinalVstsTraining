# Cardinal VSTS Training

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
4. Select "External Git" as your Source Control provider
5. Choose the ASP.NET template
6. Queue a build and use the "Default" agent pool that we setup our agent on
