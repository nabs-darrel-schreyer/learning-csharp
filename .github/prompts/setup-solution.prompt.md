---
mode: agent
---
# Setup Solution

Perform the following steps:

## Step 1: Solution File

1. Check the root folder for a `*.sln` file. 
2. If there is a `*.sln` file, you can go to the next step.
3. If it does not exist, do the following:
    - Prompt the user for a name for the solution file.
    - Create a valid .NET solution using the name of the solution provided.
4. End

## Step 2: Central Package Management (CPM) for Package Versions

1. Check the root folder for `Directory.Packages.props` file.
2. If the file exists, you can go to the next step.
3. If it does not exists, dor the following:
    - Create a new `Directory.Packages.props` file in the root folder.
    - Add the following template and save the file:
        ```xml
        <Project>
            <PropertyGroup>
                <ManagePackageVersionsCentrally>true</ManagePackageVersionsCentrally>
                <NabsVersion>9.0.137</NabsVersion>
            </PropertyGroup>
            <ItemGroup Label="Nabs Launchpad Dependencies">
                <PackageVersion Include="Nabs.Launchpad.Core.Activities" Version="$(NabsVersion)" />
                <PackageVersion Include="Nabs.Launchpad.Core.Ai" Version="$(NabsVersion)" />
                <PackageVersion Include="Nabs.Launchpad.Core.Context" Version="$(NabsVersion)" />
                <PackageVersion Include="Nabs.Launchpad.Core.Dtos" Version="$(NabsVersion)" />
                <PackageVersion Include="Nabs.Launchpad.Core.Gateway" Version="$(NabsVersion)" />
                <PackageVersion Include="Nabs.Launchpad.Core.Interfaces" Version="$(NabsVersion)" />
                <PackageVersion Include="Nabs.Launchpad.Core.Persistence" Version="$(NabsVersion)" />
                <PackageVersion Include="Nabs.Launchpad.Core.Portal" Version="$(NabsVersion)" />
                <PackageVersion Include="Nabs.Launchpad.Core.SeedData" Version="$(NabsVersion)" />
                <PackageVersion Include="Nabs.Launchpad.Core.ServiceDefaults" Version="$(NabsVersion)" />
                <PackageVersion Include="Nabs.Launchpad.Core.Silo" Version="$(NabsVersion)" />
                <PackageVersion Include="Nabs.Launchpad.Core.SiloClient" Version="$(NabsVersion)" />
                <PackageVersion Include="Nabs.Launchpad.Core.Testing" Version="$(NabsVersion)" />
                <PackageVersion Include="Nabs.Launchpad.Core.Testing.Silos" Version="$(NabsVersion)" />
                <PackageVersion Include="Nabs.Launchpad.Core.ViewModels" Version="$(NabsVersion)" />
                <PackageVersion Include="Nabs.Launchpad.Ui.Shell" Version="$(NabsVersion)" />
                <PackageVersion Include="Nabs.Launchpad.Ui.Shell.Blazor.Sf" Version="$(NabsVersion)" />
            </ItemGroup>
        </Project>
        ```
4. Update the packages to the latest versions.
5. End

## Step 3: Central Package Management (CPM) for Project Files

1. Check the root folder for `Directory.Build.props` file.
2. If the file exists, you can go to the next step.
3. If it does not exists, dor the following:
    - Create a new `Directory.Build.props` file in the root folder.
    - Add the following template and save the file:
        ```xml
        <Project>
            <PropertyGroup>
                <TargetFramework>net9.0</TargetFramework>
                <Nullable>enable</Nullable>
                <ImplicitUsings>enable</ImplicitUsings>
                <LangVersion>latest</LangVersion>
                <Copyright>Net Advantage Business Solutions</Copyright>
                <ProductName>[SolutionName]</ProductName>
                <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
                <EnforceCodeStyleInBuild>true</EnforceCodeStyleInBuild>
                <SuppressNETCoreSdkPreviewMessage>false</SuppressNETCoreSdkPreviewMessage>
                <GenerateDocumentationFile>false</GenerateDocumentationFile>
                <DebugType>full</DebugType>
                <DebugSymbols>true</DebugSymbols>
            </PropertyGroup>
            <PropertyGroup>
                <!--
                All projects don't need XML docs
                CS1573: Parameter 'parameter' has no matching param tag in the XML comment for 'parameter' (but other parameters do)
                CS1591: Missing XML comment for publicly visible type or member 'Type_or_Member'
                CS1712: Type parameter 'type_parameter' has no matching typeparam tag in the XML comment on 'type_or_member' (but other type parameters do)
                -->
                <NoWarn>$(NoWarn);1573;1591;1712</NoWarn>
            </PropertyGroup>
        </Project>
        ```
4. Replace `[SolutionName]`, if exists in the file, with the actual name of the solution.
5. If there are any projects in the solution that have the same elements in the `PropertyGroup` element, they should be removed out of the `.csproj` files so that the `Directory.Build.props` file is used to centrally specify those values.

## End Step:
This indicates that the steps are completed.