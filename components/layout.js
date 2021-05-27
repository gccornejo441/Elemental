import Head from 'next/head'

const Layout = ({ children }) => {
    return (
      <>
        <Head>
          <meta charSet="utf-8" />
          <meta httpEquiv="X-UA-Compatible" content="IE=edge" />
          <link rel="icon" type="image/png" href="/favicon.png"></link>
          <title>Title Here</title>
        <script
            async
            defer
            crossorigin="anonymous"
            src="https://connect.facebook.net/en_US/sdk.js"
          />
          <div id="fb-root"></div>
<script async defer crossorigin="anonymous" src="https://connect.facebook.net/en_US/sdk.js#xfbml=1&version=v10.0&appId=823492158525510&autoLogAppEvents=1" nonce="6VBsh9ke"></script>
          <script type="text/javascript" src="/js/facebookSDK.js"></script>
        </Head>
        {children}
        </>
      )
  }
  export default Layout;