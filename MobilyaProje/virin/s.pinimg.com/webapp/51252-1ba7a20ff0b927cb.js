"use strict";(self.__LOADABLE_LOADED_CHUNKS__=self.__LOADABLE_LOADED_CHUNKS__||[]).push([[51252],{697974:function(e,n,t){t.r(n),t.d(n,{exchangeTokenAndSetSession:function(){return l},verifyLoggedInStatus:function(){return _},registerUser:function(){return d},loginUser:function(){return f}});var o=t(238402),r=t(311866),a=t(180307),i=t(641483),c=t(116955),s=a.Z.settings.ACCOUNTS_PINTEREST_URL,u=function(e,n,t,o){var r=function(e){var n=new Error(e.statusText);throw n.response=e,!n.api_error_code&&n.response&&(n.api_error_code=n.response.code,n.message=n.response.message),n},a={credentials:"include",mode:"cors"};return"POST"===t&&(a.method="POST",a.body=n,a.headers={"Content-type":"application/x-www-form-urlencoded; charset=UTF-8","X-Pinterest-InstallId":o},o||(0,i.ZP)("unauth.auth_handshake.cross_domain.no_unauth_id.".concat(t))),fetch(e,a).then((function(e){return 200===e.status||401===e.status||409===e.status?e:(r(e),{})})).then((function(e){return e.json()})).then((function(e){return"success"===e.status?Promise.resolve(e):e.code===c.Zn?(e.api_error_code=e.code,Promise.reject(e)):(r(e),{})})).catch((function(e){throw e}))},l=function(e){var n=arguments.length>1&&void 0!==arguments[1]&&arguments[1];return r.ZP.create("HandshakeSessionResource",{token:e,isRegistration:n}).callCreate()},_=function(e){u("".concat(s,"/v3/handshake/verify/"),"","GET",e).then((function(e){if(e&&e.data){var n=e.data;l(n).then((function(e){window.location.reload()}),(function(e){}))}}),(function(e){}))},d=function(e,n){var t=n.facebookToken,r=n.inviteCode,i=n.locale,c=n.referrer,s=n.unauthId,l=(e.business_name?"partner/handshake":(e.gplus_code||e.gplus_id_token)&&"gplus/handshake")||e.facebook_id&&"facebook/handshake"||"email/handshake",_={};if(_.email=e.email||"",_.username=e.username||"",_.password=e.password||"",_.first_name=e.first_name||"",_.last_name=e.last_name||"",_.country=e.country||"",_.locale=i,_.referrer=c,e.age){var d=new Date;d.setFullYear(d.getFullYear()-e.age);var f=parseInt(d/1e3,10);_.birthday=f.toString()}if(e.custom_gender&&(_.custom_gender=e.custom_gender),e.gender&&(_.gender=e.gender),e.business_name&&(_.account_type=e.account_type,_.business_name=e.business_name,_.first_name=e.business_name),r&&(_.invite_code=r),e.facebook_id){var g=t||e.facebook_token||"";_.facebook_id=e.facebook_id,_.facebook_token=g,_.social_username=e.social_username||""}else(e.gplus_code||e.gplus_id_token)&&(_.password=e.password||"",_.one_time_code=e.gplus_code,_.id_token=e.gplus_id_token,_.redirect_uri=e.gplus_redirect_uri);return e.recaptchaV3Token&&(_.recaptcha_v3_token=e.recaptchaV3Token),u("".concat(a.Z.settings.ACCOUNTS_PINTEREST_URL,"/v3/register/").concat(l,"/"),(0,o.Z)(_),"POST",s)},f=function(e,n){var t=n.facebookToken,r=n.recaptchaV3Token,i=n.referrer,c=n.unauthId,s=(e.mfa_token?"mfa/handshake":e.gplus_id_token&&"gplus/handshake")||e.facebook_id&&"facebook/handshake"||"handshake",l={};if(e.username_or_email&&(l.username_or_email=e.username_or_email.trim(),l.password=e.password,l.referrer=i),e.facebook_id){var _=t||e.facebook_token||"";l.facebook_id=e.facebook_id,l.facebook_token=_,l.facebook_autologin=e.facebook_autologin||!1}return e.gplus_id_token&&(l.gplus_id_token=e.gplus_id_token,l.gplus_access_token=e.gplus_access_token,l.gplus_expires_at=e.gplus_expires_at,l.gplus_autologin=e.gplus_autologin||!1),e.mfa_token&&(l.mfa_token=e.mfa_token),r&&(l.token=r),u("".concat(a.Z.settings.ACCOUNTS_PINTEREST_URL,"/v3/login/").concat(s,"/"),(0,o.Z)(l),"POST",c)}},851252:function(e,n,t){var o=t(85038),r=t(311866),a=t(233088),i=t(180307),c=t(349512),s=t(116955),u=t(746517),l=t(538504),_=t(611277),d=t(804652),f=t(641483),g=t(688239),h=t(304988),p=t(250933),k=t(697974);function m(e,n){var t=Object.keys(e);if(Object.getOwnPropertySymbols){var o=Object.getOwnPropertySymbols(e);n&&(o=o.filter((function(n){return Object.getOwnPropertyDescriptor(e,n).enumerable}))),t.push.apply(t,o)}return t}function v(e){for(var n=1;n<arguments.length;n++){var t=null!=arguments[n]?arguments[n]:{};n%2?m(Object(t),!0).forEach((function(n){w(e,n,t[n])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(t)):m(Object(t)).forEach((function(n){Object.defineProperty(e,n,Object.getOwnPropertyDescriptor(t,n))}))}return e}function w(e,n,t){return n in e?Object.defineProperty(e,n,{value:t,enumerable:!0,configurable:!0,writable:!0}):e[n]=t,e}var b=function(e,n){var t=arguments.length>2&&void 0!==arguments[2]?arguments[2]:"",o=arguments.length>3&&void 0!==arguments[3]?arguments[3]:"",r=arguments.length>4&&void 0!==arguments[4]&&arguments[4],a="referrer_unknown";try{var i=document.referrer;a=i?i.indexOf("/t.co/")>-1?"twitter":i.indexOf("google.")>-1?"google":i.indexOf("bing.")>-1?"bing":i.indexOf("facebook.")>-1?"facebook":"other":"direct"}catch(v){}var s=(0,u.eD)(e),l=n===Object(n)?n.hybridTier:"tier_unknown",_=n===Object(n)?n.container:"container_unknown";(0,f.ZP)("login.referrer."+a+"."+s),(0,f.ZP)("login.container."+_+"."+s),(0,f.ZP)("login.type."+s);var d=(0,u.eD)(e)||"method_unknown",k=n.page||"page_unknown";e.gplus_autologin?r?((0,f.ZP)("mweb_autologin.google_success"),(0,f.hL)("new_mweb_autologin_google",{page:k,referrer:a,container:_,hybridTier:l})):((0,f.ZP)("web_autologin_google"),(0,f.hL)("new_web_autologin_google",{page:k,referrer:a,container:_,hybridTier:l})):e.facebook_autologin?((0,f.ZP)("web_autologin_facebook"),(0,f.hL)("new_web_autologin_facebook",{page:k,referrer:a,container:_,hybridTier:l})):((0,f.ZP)("web_login.".concat(d,".success.").concat(k,".").concat(_,".").concat(a,".").concat(l)),(0,f.hL)("new_web_login.".concat(d,".success"),{page:k,referrer:a,container:_,hybridTier:l})),(0,p.c_)(t)&&(0,h.yP)({id:c.bJ,eventCategory:"Logins",eventName:"Desktop"}),(0,p.$r)(t,o)&&(0,h.jw)({id:"flashtalking-d-login",eventCategory:"Logins",eventName:"Desktop"}),(0,p.NR)(t,o)&&(0,h.EN)({pixelId:g.Rj,eventCategory:"Logins",eventName:"Desktop"}),(0,p.Fc)(t)&&(0,h.Be)({pixelId:g.HO,eventCategory:"Logins",eventName:"Desktop"});var m=e.facebook_autologin||e.gplus_autologin||e.autologin?"autologin":"login";(0,f.De)({action:m,event:"success",type:s})},E=function(e,n){(0,f.ZP)("web_cross_domain_login.".concat(e,".").concat((0,u.eD)(n)))},O=function(e){return!e.mfa_resend&&!!e.username_or_email},P=function(e,n){var t=arguments.length>2&&void 0!==arguments[2]?arguments[2]:"other",o=arguments.length>3&&void 0!==arguments[3]&&arguments[3];if(e){var r=e.http_status===l.E?l.E:e.api_error_code,a=r;s.qF.has(r)&&(a=s.qF.get(r));var i=n.container;o?(0,f.ZP)("unauth_web_client_cctld_login_api_error.".concat(String(a),".").concat(i||"unknow_container",".").concat(t)):(0,f.ZP)("unauth_web_client_login_api_error.".concat(String(a),".").concat(i||"unknow_container",".").concat(t)),(0,f.De)({action:"login",event:"fail",type:t})}},y=function(e,n,t,o){E("attempt",e);var r=o.referrer,a=o.facebookToken,i=o.unauthId;return(0,k.loginUser)(e,{recaptchaV3Token:n,referrer:r,facebookToken:a,unauthId:i}).then((function(n){if(n&&n.data){E("success_with_token",e);var o=n.data;return(0,k.exchangeTokenAndSetSession)(o).then((function(n){return E("success_token_exchanged",e),b(e,t),Promise.resolve()}),(function(n){throw E("success_token_not_exchanged",e),n}))}throw E("success_without_token",e),new Error}),(function(n){throw E("failure",e),P(n,t,(0,u.eD)(e),!0),n}))};n.Z=function(e,n){var t=arguments.length>2&&void 0!==arguments[2]?arguments[2]:{},c=arguments.length>3&&void 0!==arguments[3]&&arguments[3],s=arguments.length>4?arguments[4]:void 0,l=arguments.length>5?arguments[5]:void 0,f=arguments.length>6&&void 0!==arguments[6]&&arguments[6];if(O(e)){var g=i.Z.settings.CORS_HANDSHAKE_DOMAINS;if(-1!==g.indexOf(n.origin))return y(e,l,t,n)}var h=c?null:a.ZP.localStorage.getItem("visitedPagesBeforeLogin"),p=v(v({},e),{},{get_user:e.get_user||e.switch_account&&c,app_type_from_client:7===n.appType?7:5,visited_pages_before_login:h?JSON.stringify(h):null,recaptchaV2Token:s,recaptchaV3Token:l}),k=r.ZP.create("UserSessionResource",p),m={showError:!1,async:!0};return k.callCreate(m).then((function(n){var r=(n||{}).client_context||{},a=r.country,i=r.active_experiments,c=r.region_from_ip;return b(e,t,a,c,f),(0,_.B)(!1),i&&i.web_cctld_cookies_cleanup&&"enabled"===i.web_cctld_cookies_cleanup&&(o.zN("fba"),o.zN("logged_out")),(0,d.Dm)("login").then((function(){return n}))}),(function(n){return P(n,t,(0,u.eD)(e)),Promise.reject(n)}))}},611277:function(e,n,t){t.d(n,{a:function(){return r},B:function(){return a}});var o=t(233088),r=function(){return o.ZP.localStorage.getItem("uoiou")||!1},a=function(e){o.ZP.localStorage.setItem("uoiou",!!e)}},746517:function(e,n,t){t.d(n,{Ny:function(){return m},lp:function(){return O},eD:function(){return P}});var o=t(85038),r=t(773432),a=t(185062),i=t(205794),c=t(311866),s=t(233088),u=t(180307),l=t(538504),_=t(899679),d=t(641483),f=t(116955),g=t(80209);function h(e,n){for(var t=0;t<n.length;t++){var o=n[t];o.enumerable=o.enumerable||!1,o.configurable=!0,"value"in o&&(o.writable=!0),Object.defineProperty(e,o.key,o)}}function p(e,n){(null==n||n>e.length)&&(n=e.length);for(var t=0,o=new Array(n);t<n;t++)o[t]=e[t];return o}var k,m=Object.freeze({SOFT_BANNED:0,RATE_LIMITED:1,LOGIN_ASSISTANCE:2,PASSWORD_RESET_SENT:3,PREVENT_FACEBOOK_REGISTER:4,PREVENT_GOOGLE_REGISTER:5,SUSPENDED:6}),v=[f.OW,f.bd,f.$j,f.an,f.RL,f.yV,l.E],w=([].concat(v,[f.nY,f.iK,f.E6,f.oP,f.an]),v.filter((function(e){return e!==f.RL&&e!==f.an}))),b=[].concat(function(e){if(Array.isArray(e))return p(e)}(k=w)||function(e){if("undefined"!=typeof Symbol&&null!=e[Symbol.iterator]||null!=e["@@iterator"])return Array.from(e)}(k)||function(e,n){if(e){if("string"==typeof e)return p(e,n);var t=Object.prototype.toString.call(e).slice(8,-1);return"Object"===t&&e.constructor&&(t=e.constructor.name),"Map"===t||"Set"===t?Array.from(e):"Arguments"===t||/^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(t)?p(e,n):void 0}}(k)||function(){throw new TypeError("Invalid attempt to spread non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method.")}(),[f.oP,f.nf]),E=function(){function e(){!function(e,n){if(!(e instanceof n))throw new TypeError("Cannot call a class as a function")}(this,e)}var n,t,_;return n=e,_=[{key:"defaultLoginRedirectUrl",value:function(){return window.location.pathname===u.Z.settings.PASSWORD_RESET_URL||window.location.pathname===u.Z.settings.LOGIN_URL||window.location.pathname.startsWith(u.Z.settings.ADD_SECONDARY_ACCOUNT_PAGE)?"/":window.location.pathname+window.location.search}},{key:"defaultSocialLoginRedirectUrl",value:function(){return window.location.pathname.startsWith(u.Z.settings.ADD_SECONDARY_ACCOUNT_PAGE)?"/":window.location.pathname}},{key:"isExceedRecaptchaLocalLimit",value:function(){var e=s.ZP.localStorage.getItem("urh");if(e&&e.indexOf("|")>-1){var n=e.split("|");return 3===n.length&&(new Date).getTime()/1e3-parseInt(n[0],10)<=3600}return!1}},{key:"updateRecaptchaTimeStamp",value:function(){var e=s.ZP.localStorage.getItem("urh"),n=[];e&&3===(n=e.split("|")).length&&n.shift();var t=((new Date).getTime()/1e3).toString();n.push(t);var o=n.join("|");s.ZP.localStorage.setItem("urh",o)}},{key:"isFullyLoggedIn",value:function(e,n){return e&&1===n}},{key:"handleRedirect",value:function(e){if(!e){e="/";var n=(0,a.Z)();if(n){var t=n.next;t&&(e=t,delete n.next),e=(0,r.Z)(e,n)}}(0,i.Z)(e)}},{key:"handleRedirectWithFallbackWindowLocation",value:function(){this.handleRedirect(this.defaultLoginRedirectUrl())}},{key:"handleSignupRedirect",value:function(n,t){s.ZP.localStorage.setItem("signupTime",Date.now()),!t&&n&&"/"!==n?e.handleRedirect(n):e.handleRedirect("/")}},{key:"storeLoginCredentialsToBrowser",value:function(e){if(navigator.credentials&&e.username_or_email)try{var n=new window.PasswordCredential({id:e.username_or_email,password:e.password});navigator.credentials.store(n).then((function(){(0,d.ZP)("navigatorCredentials.store.success")}))}catch(t){(0,d.ZP)("navigatorCredentials.store.error")}}},{key:"retrieveLoginCredentialsFromBrowser",value:function(){var e=window.navigator.credentials;return e?e.get({password:!0,mediation:"silent"}):new Promise((function(e,n){n()}))}},{key:"attemptLoginWithBrowserCredentials",value:function(e,n,t){return e?(e.password?(r="include",(o=new FormData).append("username",e.id),o.append("password",e.password)):r=e,fetch("/resource/UserSessionResource/create/",{method:"POST",body:o,credentials:r,headers:{Accept:"application/json, text/javascript, */*","X-CSRFToken":n||"","X-Pinterest-AppState":t,"X-Requested-With":"XMLHttpRequest"}}).then((function(e){if(200!==e.status){var n=new Error(e.statusText);throw n.response=e,n}return(0,d.ZP)("navigatorCredentials.login.success"),e.json()})).catch((function(e){return(0,d.ZP)("navigatorCredentials.login.failure"),Promise.reject(e)}))):new Promise((function(e,n){n("No credentials")}));var o,r}},{key:"fetchRecentlyLoggedOutUser",value:function(e){if(e)return Promise.reject();var n=c.ZP.create("UnauthUserDataResource");return new Promise((function(e,t){n.callGet().then((function(n){var r=n.resource_response.data,a=!!o.U2("logged_out");return r?(r.connected_to_facebook||r.connected_to_google||r.has_password||(0,d.ZP)("unauth.personalized_login.no_login_methods_found"),(0,d.ZP)("unauth.personalized_login.fetch_user_info.info.user_info_found.logged_out_cookie_".concat(a?"true":"false")),e(r)):((0,d.ZP)("unauth.personalized_login.fetch_user_info.info.no_user_info.logged_out_cookie_".concat(a?"true":"false")),t({}))})).catch((function(e){if(e.message){var n=e.message.replace(/\s/g,"_").toLowerCase();(0,d.ZP)("unauth.personalized_login.fetch_user_info.error.".concat(n))}else(0,d.ZP)("unauth.personalized_login.fetch_user_info.error.unknown");return t(e)}))}))}},{key:"handleLoginMfa",value:function(n,t,o){(0,d.ZP)("multi_step_login"),e.storeLoginCredentialsToBrowser(n),o?o(n,t):(0,d.ZP)("unauth.login.error.CLIENT_ERROR.null_mfa_handler")}},{key:"getLoginErrorState",value:function(e,n,t,o,r){var a,i=null,c=e.http_status||e.httpStatus,s=e.api_error_code||e.apiErrorCode;if(c===l.E&&(s=l.E),a=b.includes(s)?(0,g.jsx)(o,{api_error_code:s,errorMessage:e.message,handleTouch:function(){return r(m.PASSWORD_RESET_SENT)},source:n,userSearch:t}):e.message)switch(s){case f.oP:case f.RL:i={passwordValidationError:a};break;case f.nY:i={facebookValidationError:a};break;case f.iK:i={googleValidationError:a};break;case f.hU:i={emailValidationError:a};break;case f._K:i={passwordValidationError:a};break;default:i={emailValidationError:a}}else(0,d.ZP)("unauth.login.error.SERVER_ERROR.unknown.".concat(s,".").concat(n));return i}}],(t=null)&&h(n.prototype,t),_&&h(n,_),e}();function O(e){return e.facebook_id?_.sr.FACEBOOK:e.google_open_id_token?_.sr.GOOGLE_ONE_TAP:e.gplus_id_token?_.sr.GOOGLE:e.line_id_token?_.sr.LINE:e.username_or_email?_.sr.EMAIL:_.sr.OTHER}function P(e){return e.mfa_token?"mfa_token":e.mfa_resend?"mfa_resend":O(e)}n.ZP=E},899679:function(e,n,t){t.d(n,{sr:function(){return r},sR:function(){return a},NN:function(){return i},r4:function(){return c}});var o=t(180307),r={FACEBOOK:"facebook",GOOGLE_ONE_TAP:"google_one_tap",GOOGLE:"google",LINE:"line",EMAIL:"email",OTHER:"other"},a=function(e){return e.facebook_id?r.FACEBOOK:e.google_open_id_token?r.GOOGLE_ONE_TAP:e.gplus_code||e.gplus_id_token?r.GOOGLE:e.line_id_token?r.LINE:e.email?r.EMAIL:r.OTHER},i=function(){var e=arguments.length>0&&void 0!==arguments[0]?arguments[0]:"";return e in o.Z.settings.MINIMUM_AGE_BY_EU_COUNTRY},c=function(e){return o.Z.settings.EN_COUNTRIES_WITH_MANDATORY_AGE.includes(e)||o.Z.settings.LATAM_AGE_COLLECTION.has(e)}},538504:function(e,n,t){t.d(n,{A:function(){return o},E:function(){return r}});var o=412,r=429}}]);
//# sourceMappingURL=https://sm.pinimg.com/webapp/51252-1ba7a20ff0b927cb.js.map