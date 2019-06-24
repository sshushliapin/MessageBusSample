# MessageBus sample

## Prerequisites

1. Build [Sitecore 9.1.1 Docker images](https://github.com/Sitecore/docker-images):

   ```powershell
   Import-Module ".\modules\SitecoreImageBuilder" -Force

   SitecoreImageBuilder\Invoke-Build -Path ".\images" -InstallSourcePath C:\tools\SIMRepository -Registry myregistry -Tags "*9.1.1*" -PushMode "WhenChanged"
   ```
