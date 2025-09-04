document.addEventListener('DOMContentLoaded', function () {
    const signInBtn = document.querySelector('.btn.btn-third[href="/Home/Index"]');
    if (signInBtn) {
        signInBtn.addEventListener('click', function (e) {
            e.preventDefault();
            const role = document.getElementById('role').value;
            if (!role) {
                alert('Please select a role.');
                return;
            }
            // Store role in localStorage
            localStorage.setItem('userRole', role);

            // Redirect based on role
            if (role === 'lecturer') {
                window.location.href = '/ClaimSubmission';
            } else if (role === 'coordinator') {
                window.location.href = '/ViewClaims';
            } else if (role === 'Manager') {
                window.location.href = '/Approvals';
            }
        });
    }

        document.addEventListener('DOMContentLoaded', function () {
        const path = window.location.pathname.toLowerCase();
        const isAuthPage = path === '/login/index' || path === '/registration/index';
        const isHomePage = path === '/home/index' || path === '/';
        if (!isAuthPage && !isHomePage) {
            const userRole = localStorage.getItem('userRole');
        document.querySelectorAll('#roleNav li').forEach(function (li) {
                const role = li.getAttribute('data-role');
        if (role === 'all' || role === userRole) {
            li.style.display = '';
                } else {
            li.style.display = 'none';
                }
            });
        }
    });
 
});