fetch('http://localhost:5290/api/users')
    .then(response => response.json())
    .then(data => {
        const userList = document.getElementById('user-list');
        data.forEach(user => {
            const row = document.createElement('tr');
            row.innerHTML = `
                <td>${user.id}</td>
                <td>${user.name}</td>
            `;
            userList.appendChild(row);
        });
    })
    .catch(error => console.error('Error:', error));
