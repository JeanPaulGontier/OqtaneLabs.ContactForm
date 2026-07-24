del "*.nupkg"
"..\..\oqtane.framework-10.2.1\oqtane.package\nuget.exe" pack OqtaneLabs.ContactForm.nuspec 
XCOPY "*.nupkg" "..\..\oqtane.framework-10.2.1\Oqtane.Server\Packages\" /Y
