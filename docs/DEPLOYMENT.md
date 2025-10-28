Deployment guide
================

This document explains minimal steps to deploy the project.

Options provided by the repository:

- Docker: the repository contains a `Dockerfile` at `api/PYWalkingApp/Dockerfile` that builds a multi-stage image for the .NET 8 app.
- GitHub Actions: a workflow at `.github/workflows/ci-deploy.yml` builds the project and uploads a publish artifact. If `secrets.GITHUB_TOKEN` is present it will also try to push a Docker image to GHCR. If you provide `AZURE_WEBAPP_PUBLISH_PROFILE` it will deploy to an Azure Web App.

How to build locally with Docker
-------------------------------

1. Build the image:

```powershell
docker build -t pywalkingapp -f api/PYWalkingApp/Dockerfile .
```

2. Run the container (map port 8080 to container 80):

```powershell
docker run --rm -p 8080:80 --env ASPNETCORE_ENVIRONMENT=Development pywalkingapp
```

Using GitHub Actions
--------------------

1. Push to a branch (already on `feat/add-DB-Connexion`).
2. The workflow `CI & Optional Deploy` will run on push and PR. It produces a publish artifact and will build/push an image to GHCR if `secrets.GITHUB_TOKEN` is available.

Deploy to Azure Web App (optional)
---------------------------------

1. Create an Azure Web App for Containers or for Code.
2. In GitHub repository settings, add a secret named `AZURE_WEBAPP_PUBLISH_PROFILE` containing the publish profile (downloadable from the Azure portal for the Web App).
3. Push to the repository — the workflow will deploy the `publish` directory to the Web App.

Notes about secrets
-------------------

- In development we use `dotnet user-secrets` to store `MONGO_CONNECTION`. In production you should use environment variables or a secret manager.
- If you need, I can help configure GHCR permissions or automate release tagging.
