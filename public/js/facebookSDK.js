
export const fbInit = () => {
    const fbAsync = new Promise((resolve) => {
       if (resolve) { 
           fbAsyncInit = function() {
            FB.init({
              appId            : '823492158525510',
              autoLogAppEvents : true,
              xfbml            : true,
              version          : 'v10.0'
            })
        }
    }
    })

    fbAsync.then(
        FB.login(function(response) {
            if (response.authResponse) {
             console.log('Welcome!  Fetching your information.... ');
             FB.api('/me', function(response) {
               console.log('Good to see you, ' + response.name + '.');
             });
            } else {
             console.log('User cancelled login or did not fully authorize.');
            }
        })
    )
}

