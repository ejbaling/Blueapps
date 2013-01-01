#*****************************************************************
#*********** BEGIN Template Parameters ***************************
#*****************************************************************

# path to the project's edmx data model (entity framework data model)
$edmxFilePath = "..\..\Blueapps.Data.Ef\Blueapps.edmx"
# the namepace name where the solution's domain models live 
$domainModelNamespace = "Blueapps.Core.Domain"
# the namespace name where the solution's services will live
$serviceInterfaceNamespace = "Blueapps.Core.Services"
# the namespace name where the solution's repository will live
$repositoryInterfaceNamespace = "Blueapps.Core.Repository"

#*****************************************************************
#*********** END Template Parameters *****************************
#*****************************************************************

function createDirectory($directory){
    New-Item $directory -type directory -force    
}

function removeDestinationFile($file){
    if(Test-Path $file){ Remove-Item $file }
}

function writeout($file){
    $sourceFile = "Source/" + $file
    $destinationDirectory = "Solution/"    
    $destinationFile = $destinationDirectory + $file
    
    createDirectory($destinationDirectory)    
    removeDestinationFile($destinationFile)
    
    (Get-Content $sourceFile) |
    Foreach-Object {$_ -replace "\[\*\*EDMX_FILE_PATH\*\*\]", $edmxFilePath} | 
    Foreach-Object {$_ -replace "\[\*\*DOMAIN_MODEL_NAMESPACE\*\*\]", $domainModelNamespace} |
    Foreach-Object {$_ -replace "\[\*\*SERVICE_INTERFACE_NAMESPACE\*\*]", $serviceInterfaceNamespace} |
    Foreach-Object {$_ -replace "\[\*\*REPOSITORY_INTERFACE_NAMESPACE\*\*\]", $repositoryInterfaceNamespace} |
    Set-Content $destinationFile
}

$files = @("Domain.Poco.tt", "Domain.Poco.Metadata.tt", "Repository.Interface.tt", "Service.Interface.tt", "Repository.Implementation.EF.tt", "Service.Implementation.tt")

foreach($file in $files){
    writeout($file)
}