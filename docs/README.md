# 🗺️ Py Walking App

Application web pour afficher et partager des **lieux et tracés GPX** sur une carte interactive.  
Chaque point peut inclure des **photos** et un **résumé** descriptif.

---

## 🚀 Objectifs

- Afficher une carte (IGN / OSM)
- Permettre d’ajouter des **pins** géolocalisés
- Uploader et visualiser des **fichiers GPX**
- Associer **photos** et **résumés** à chaque lieu ou tracé
- Authentification simple (user / email)
- Application 100% gratuite et hébergeable facilement

---

## 🧱 Stack technique

| Couche | Technologie | Rôle |
|---------|--------------|------|
| Frontend | **Angular** + **Leaflet** + **leaflet-gpx** | Affichage carte et GPX |
| Backend | **.NET 8 Minimal API** | API REST (pins, tracks, upload) |
| Base de données | **MongoDB Atlas (Free Tier)** | Stockage NoSQL des lieux, tracés, photos |
| Stockage fichiers | **Cloudinary** (images & GPX) | CDN et gestion des médias |
| Auth | Simple JWT (ou futur Supabase/Auth0) | |
| Hébergement | **Vercel** (front) + **Render/Fly.io** (API) | Déploiement gratuit |

---

## 🧩 Roadmap MVP

| Status | Tâche | Type |
|---------|--------|------|
| ⏳ | Créer le repo + CI GitHub Actions | Tech |
| ⏳ | Intégrer Leaflet + OSM sur Angular | Front |
| ⏳ | Endpoint `/api/pins` (CRUD MongoDB) | Back |
| ⏳ | Upload Cloudinary (photo + GPX) | Back |
| ⏳ | Affichage GPX via leaflet-gpx | Front |
| ⏳ | Auth utilisateur simple (JWT) | Back |
| ⏳ | Déploiement sur Vercel + Render | Ops |

💡 Chaque tâche doit être une **Issue GitHub** liée au **Project Kanban "MVP"** — Colonnes : `Todo` / `In Progress` / `Done`

