$configFiles = Get-ChildItem . *.* -rec -Exclude *.dll,*.exe,*.ps1,*.png
$projectName = $args[0]
$replaceFind = "RTS.Template"
$replaceWith = "RTS.$projectName"

# Find and replace in files
foreach ($file in $configFiles)
{
    if (! $file.PSIsContainer)
    {
        (Get-Content $file.PSPath) |
        Foreach-Object { $_ -replace $replaceFind, $replaceWith } |
        Set-Content $file.PSPath
    }
}

# Rename Files
foreach ($file in $configFiles)
{
    if (! $file.PSIsContainer -And $file.name -like '*RTS.Template*')
    {
        $newname = $file.name.Replace($replaceFind, $replaceWith)
        Write-Output $file.PSPath
        Write-Output $newname
        Rename-item -Path $file.PSPath $newname
    }
}

# Rename Dirs
foreach ($file in $configFiles)
{
    if ($file.PSIsContainer -And $file.name -like '*RTS.Template*')
    {
        $newname = $file.name.Replace($replaceFind, $replaceWith)
        Write-Output $file.PSPath
        Write-Output $newname
        Rename-item -Path $file.PSPath $newname
    }
}

Write-Output "Done."
Remove-Item -LiteralPath $MyInvocation.MyCommand.Path -Force