# Career Tracker - Development Log 📋

## Current Status (v1.0.2) ✅
- [x] ASP.NET Core API - `JobApplicationsController` (GET/POST working)
- [x] React frontend - Loads "Job Tracker", fetches `[]` from API  
- [x] GitHub repo: https://github.com/longle7/career-tracker
- [x] CORS configured in `Program.cs`

## Local Setup 🎮
```bash
git clone https://github.com/longle7/career-tracker.git
cd career-tracker
dotnet restore  
npm install
dotnet run
```

## What's Working 🟢
- `GET /api/JobApplications` → `[]`
- `POST /api/JobApplications` → saves data (in-memory `_applications` list)
- React UI shows empty list

## Issues Fixed 🔧
- Controller 404 → Rebuild Solution
- JSON parse error → Direct backend URL (`https://localhost:7299`)
- ESLint setState warning → Fixed `useEffect`

## Quick Test Commands 🧪
**Browser Console (F12)**:
```js
fetch('https://localhost:7299/api/JobApplications').then(r=>r.json()).then(console.log)
```

**POST Test**:

fetch('https://localhost:7299/api/JobApplications', {
  method: 'POST',
  headers: {'Content-Type': 'application/json'},
  body: JSON.stringify({
    company: 'Microsoft',
    role: 'Software Engineer',
    dateApplied: '2026-03-30',
    status: 'Applied',
    notes: 'Portfolio project demo'
  })
}).then(r => r.json()).then(console.log)