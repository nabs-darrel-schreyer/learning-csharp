# Instructions for GitHub Copilot

## General

* Make only high confidence suggestions when reviewing code changes.
* Always use the latest version C#, currently C# 13 features.
* Never change global.json unless explicitly asked to.
* Do not update generated files.
* Use Central Package Management for package versioning.

## Solution Folder Structure

* The solution file is in the root folder.
* All application project folders are in the `src` sub-folder from the root folder.
* All unit test project folder are in the `tests` sub-folder from the root folder.
* All documentation can be found in the `docs` sub-folder from the root folder.

## C# Types

* Always use file level namespacing.