import { useEffect, useState } from 'react';

interface JobApplication {
    id: number;
    company: string;
    role: string;
    dateApplied: string;
    status: string;
    notes: string;
}

function App() {
    const [applications, setApplications] = useState<JobApplication[]>([]);
    
    useEffect(() => {
        const loadData = async () => {
            const res = await fetch('https://localhost:7299/api/JobApplications');
            const data = await res.json();
            setApplications(data);
        };
        loadData();
    }, []);

    return (
        <div className="container mx-auto p-8">
            <h1 className="text-4xl font-bold mb-8">Job Tracker</h1>
            <div className="grid gap-4">
                {applications.map(app => (
                    <div key={app.id} className="p-4 border rounded-lg">
                        <h2 className="font-semibold">{app.company} - {app.role}</h2>
                        <p>Status: {app.status}</p>
                        <p>{app.notes}</p>
                    </div>
                ))}
            </div>
        </div>
    );
}

export default App;