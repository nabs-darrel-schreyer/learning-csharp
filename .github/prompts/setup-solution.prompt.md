---
mode: agent
---
# Setup Solution

Perform the following steps:

## Step 1: Solution File

1. Check the root folder for a `*.sln` file. 
2. If there is a `*.sln` file, you can go to Step 2.
3. If it does not exist, do the following:
    - Prompt the user for a name for the solution file.
    - Create a valid .NET solution using the name of the solution provided.
4. End

## Step 2: Central Package Management (CPM) for Package Versions

1. Check the root folder for `Directory.Packages.props` file.
2. If the file exists, you can go to End Step.
3. If it does not exists, dor the following:
    - Create a new `Directory.Packages.props` file in the root folder.
    - Add the following template and save the file:
        ```xml
        <Project>
            <PropertyGroup>
                <ManagePackageVersionsCentrally>true</ManagePackageVersionsCentrally>
            </PropertyGroup>
            <ItemGroup Label="Other Dependencies">
                <PackageVersion Include="Ardalis.Result" Version="10.1.0" />
                <PackageVersion Include="Ardalis.Result.FluentValidation" Version="10.1.0" />
                <PackageVersion Include="FluentValidation" Version="12.0.0" />
                <PackageVersion Include="CommunityToolkit.Mvvm" Version="8.4.0" />
            </ItemGroup>
        </Project>
        ```
4. Update the packages to the latest versions.
5. End

## Step 3: Central Package Management (CPM) for Project Files


## End Step:
This indicates that the steps are completed.