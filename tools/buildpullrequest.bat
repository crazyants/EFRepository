@echo off
MSBuild.SonarQube.Runner.exe begin /k:EFRepository /n:EFRepository /d:sonar.analysis.mode=issues /d:sonar.issuesReport.console.enable=true /d:sonar.host.url=https://sonarqube.com /d:sonar.login=%SONAR_TOKEN% /d:sonar.cs.opencover.reportsPaths="%CD%\CodeCoverage.xml" /d:sonar.github.pullRequest=%APPVEYOR_PULL_REQUEST_NUMBER% /d:sonar.github.repository=kirkchen/EFRepository /d:sonar.github.oauth=%GITHUB_TOKEN% /version:%APPVEYOR_BUILD_NUMBER%