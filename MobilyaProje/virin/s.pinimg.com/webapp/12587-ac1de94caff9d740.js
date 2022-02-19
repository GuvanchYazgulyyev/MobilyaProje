"use strict";(self.__LOADABLE_LOADED_CHUNKS__=self.__LOADABLE_LOADED_CHUNKS__||[]).push([[12587],{447186:function(e,t,n){var r=n(85038),o=n(799881),i=n(737614),a=n(730762),c=n(241933),u=n(311866),s=n(233088),f=n(180307),l=n(804652),d=n(641483);function p(e){return(p="function"==typeof Symbol&&"symbol"==typeof Symbol.iterator?function(e){return typeof e}:function(e){return e&&"function"==typeof Symbol&&e.constructor===Symbol&&e!==Symbol.prototype?"symbol":typeof e})(e)}function m(e,t){for(var n=0;n<t.length;n++){var r=t[n];r.enumerable=r.enumerable||!1,r.configurable=!0,"value"in r&&(r.writable=!0),Object.defineProperty(e,r.key,r)}}var v=function(){function e(){var t,n,r;!function(e,t){if(!(e instanceof t))throw new TypeError("Cannot call a class as a function")}(this,e),r={},(n="attributes")in(t=this)?Object.defineProperty(t,n,{value:r,enumerable:!0,configurable:!0,writable:!0}):t[n]=r}var t,v,b;return t=e,(v=[{key:"get",value:function(e){return e in this.attributes?this.attributes[e]:void 0}},{key:"set",value:function(e,t){"object"===p(e)?Object.assign(this.attributes,e):this.attributes[e]=t}},{key:"isAuthenticated",value:function(){return!!i.Z.instance.is_authenticated}},{key:"isLimitedLogin",value:function(){return!!this.attributes.login_state&&2===this.attributes.login_state}},{key:"attemptCrossDomainAutologin",value:function(){-1===f.Z.settings.CORS_HANDSHAKE_DOMAINS.indexOf(window.location.origin)||r.U2("logged_out")||n.e(12749).then(n.bind(n,697974)).then((function(e){(0,e.verifyLoggedInStatus)(i.Z.instance.unauth_id)}))}},{key:"flushContextLogs",value:function(){c.ZP.pause(),a.Z.getInstance().flushEvents(void 0,void 0)}},{key:"logoutWithOptions",value:function(e,t,n){return(0,d.yl)(!0),this.flushContextLogs(),u.ZP.create("UserSessionResource",{disable_auth_failure_redirect:!0}).callDelete().then((function(){(0,d.tj)("logout",{tags:{app:7===i.Z.instance.app_type_detailed?"windows_desktop":"web_denzel",reason:"user_initiated",source:t}}),s.ZP.sessionStorage.clear(),s.ZP.localStorage.clear(),r.t8("fba","True",720)})).then((function(){return(0,l.Dm)("logoutWithOptions")})).then((function(){if(n)for(var t in n)s.ZP.localStorage.setItem(t,n[t]);null!==e&&(0,o.Z)(e)}))}},{key:"isWriteBanned",value:function(){if(this.attributes.nags&&Array.isArray(this.attributes.nags)){var e=this.attributes.nags;return e.length>0&&"write_banned"===e[0].type}return!1}}])&&m(t.prototype,v),b&&m(t,b),e}();t.Z=new v},666584:function(e,t,n){n.d(t,{cA:function(){return R},fM:function(){return Z},N5:function(){return B}});var r=n(793550),o=n(68348),i=function(e){var t=e.deviceType,n=e.isBot,r=e.isSocialBot;return"coreWebVitalsLite.v1.".concat((r?"socialBot":n&&"bot")||"nonbot",".").concat(t)},a=n(731164),c=n(256721),u=n(182513),s=n(378956);function f(e,t){var n=Object.keys(e);if(Object.getOwnPropertySymbols){var r=Object.getOwnPropertySymbols(e);t&&(r=r.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),n.push.apply(n,r)}return n}function l(e){for(var t=1;t<arguments.length;t++){var n=null!=arguments[t]?arguments[t]:{};t%2?f(Object(n),!0).forEach((function(t){d(e,t,n[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(n)):f(Object(n)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(n,t))}))}return e}function d(e,t,n){return t in e?Object.defineProperty(e,t,{value:n,enumerable:!0,configurable:!0,writable:!0}):e[t]=n,e}var p=(0,u.X)("LayoutShiftDebugger"),m=function e(t){return t instanceof HTMLElement&&t.dataset&&(t.dataset.layoutShiftBoundaryId||t.dataset.testId)||t.parentNode&&e(t.parentNode)||null},v=function(e){return Math.round(1e3*e)},b=[],y=function(e){var t=Object.freeze({}),n=0;b.forEach((function(e){var r=e.value,o=e.shift.sources,i=e.route,a=e.hadRecentNavigation,c=e.hadRecentScroll;if(n+=r,o&&o.length){var u=r/o.length;o.forEach((function(e){var n=e.node,r=n?m(n)||"ROOT":"NODE_REMOVED",o={route:i,boundaryId:r,hadRecentNavigation:a,hadRecentScroll:c},s=JSON.stringify(o);t=l(l({},t),{},d({},s,{score:((t[s]||{}).score||0)+u,tags:o}))}))}})),Object.keys(t).forEach((function(n){var r=t[n],o=r.score,i=r.tags;a.Z.count("".concat(e,".shifts"),v(o),1,l({},i))})),p("Debug CLS boundaries",n,t,b),b=[]},h=function(e){var t=e.staticContext,n=e.getCurrentRoute,r=e.getLastNavigationTime,o=(0,c.Jx)({annotateMarks:["initialAppLoad","RenderReactContainer"],name:"cumulative_layout_shift",pwtStaticContext:t}),u=0,f=function(e){u=e.timeStamp};window.addEventListener("scroll",f),window.addEventListener("beforeunload",(function(){window.removeEventListener("scroll",f)}));var l,d,p="".concat(i(t),".CLS"),m=0,h=0,g=0;(0,s.kz)((function(e){var t=e.entries,o=e.value;if(g=o||0,t.length){l=n(),d=r();var i=t[0].startTime,a=m!==i,c=a?t:t.slice(h);a&&(m=i),b=b.concat(c.map((function(e){return{value:o,shift:e,route:l,hadRecentNavigation:d>0&&d+500>e.startTime,hadRecentScroll:u>0&&u+500>e.startTime}}))),h=t.length}}),!0);var w=setInterval((function(){if(b.length){y(p);var e=(t=g)<=.1?"good":t<=.25?"adequate":"poor";a.Z.count("".concat(p,".").concat(e),1,1),o.stop(v(g))}var t}),1e3);window.addEventListener("beforeunload",(function(){clearInterval(w),0===g&&o.abort("no_shifts_detected")}))},g=n(641239);function w(e){return function(e){if(Array.isArray(e))return O(e)}(e)||function(e){if("undefined"!=typeof Symbol&&null!=e[Symbol.iterator]||null!=e["@@iterator"])return Array.from(e)}(e)||function(e,t){if(!e)return;if("string"==typeof e)return O(e,t);var n=Object.prototype.toString.call(e).slice(8,-1);"Object"===n&&e.constructor&&(n=e.constructor.name);if("Map"===n||"Set"===n)return Array.from(e);if("Arguments"===n||/^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(n))return O(e,t)}(e)||function(){throw new TypeError("Invalid attempt to spread non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method.")}()}function O(e,t){(null==t||t>e.length)&&(t=e.length);for(var n=0,r=new Array(t);n<t;n++)r[n]=e[n];return r}var S={pin_closeup:{LCP:"pin_closeup_lcp",FID:"pin_closeup_fid"},board:{LCP:"board_lcp",FID:"board_fid"}},E=function(e){var t=e.surface;if(e.isAuthenticated)return[];switch(t){case"pin_closeup":return["mweb_pin_page_ssr_lite"];default:return[]}},j=function(e){var t=e.pwtStaticContext,n=e.surface,r="pin_closeup"===n||"board"===n?function(e){var t=e.pwtStaticContext,n=e.surface,r=(0,c.Jx)({annotateExperiments:E({surface:n,isAuthenticated:t.isAuthenticated}),annotateResourceTimingForSurface:n,annotateMarks:["initialAppLoad","RenderReactContainer"].concat(w(t.isAuthenticated?[]:["firstClientRenderUnauthPageWrapper","mountUnauthPageWrapper"]),w("pin_closeup"===n?["firstClientRenderCloseupPage","firstClientRenderCloseupImage"]:[])),name:S[n].LCP,pwtStaticContext:t}),o=(0,c.Jx)({name:S[n].FID,pwtStaticContext:t});return function(e,t){"LCP"===e?r.stop(t):"FID"===e&&o.stop(t)}}({pwtStaticContext:t,surface:n}):null,o={},u=function(e,c){if(!o[e]){o[e]=!0;var u=i(t);if("LCPCount"===e){var s="".concat(u,".").concat(n,".").concat(e);a.Z.count("".concat(s,".sum"),c,1),a.Z.increment("".concat(s,".size"),1)}else a.Z.timing("".concat(u,".").concat(n,".").concat(e),c,1),r&&r(e,c)}};(0,s.Tx)((function(e){var t=e.value;return u("FID",function(e){return Number(e.toFixed(2))}(t))})),(0,s.Tb)((function(e){var t=e.value;u("LCPCount",(0,g.Kj)()),u("LCP",function(e){return 10*Math.round(e/10)}(t))})),(0,s.Y)((function(e){var t=e.value;return u("FCP",t)}))},_=function(e){switch(e){case"/":return"homefeed";case"/pin/:id":return"pin_closeup";case"/pin/:id/visual-search":return"flashlight";case"/:username/:slug":return"board";case"/:username":return"other_profile";case"/search/:scope":return"search";case"/topics/:interest":return"topic";default:return null}},P=n(164485),A=n(139585),C=n(840059),T=n(939606),L=n(133769),D=n(272828),k=n(80209),I=(0,r.createContext)(null),x=(0,r.createContext)(null);function R(e){var t,n=e.children,i=e.immutableLocation,a=e.resourceTimingCacheSize,u=e.routerHistoryAction,s=e.staticContext,f=(0,r.useRef)(null),l=(0,r.useRef)(null),d=(0,r.useRef)(i),p=(0,r.useRef)(!0),m=(0,D.$B)().path,v=(0,r.useRef)(m),b=!s.isCachedRender&&(0,o.Z)(s.deviceType);if((0,r.useEffect)((function(){v.current=m}),[m]),(0,r.useEffect)((function(){if((0,L.X_)({size:a||1e3}),(0,g.UQ)(),(0,T.A9)("totalSessionVolume"),window.performance?["clearMarks","clearMeasures","clearResourceTimings","getEntries","getEntriesByName","getEntriesByType","mark","measure","now","setResourceTimingBufferSize"].forEach((function(e){window.performance[e]||(0,T.A9)("not_supported.window.performance.".concat(e))})):(0,T.A9)("not_supported.window.performance"),window.PerformanceObserver||(0,T.A9)("not_supported.window.PerformanceObserer"),(0,P.v)()||(0,T.A9)("not_supported.grid_profiler"),p.current=!1,b&&!C.is){if(function(e,t){var n,r=0,o=0,i=null,a=null,u=null,s=null,f=[],l=function e(){o+=1,u=window.requestAnimationFrame(e)},d=function(){if(s){var n=null===i||null===a?-1:a-i,l=n/(0===r?-1:r),d=(0,c.Jx)({name:"scroll_session",pwtStaticContext:e});if(!d)return;var p=f.some((function(e){return null!==i&&i-e>0&&i-e<=500})),m=t(),v=e.isAuthenticated;0===l?d.error("zero_value",{surface:m,isUserInvoked:p,isAuthenticated:v}):l<0?d.error("negative_value",{surface:m,isUserInvoked:p,isAuthenticated:v}):(d.addBinaryAnnotation("isUserInvoked",p,"BOOL"),d.addBinaryAnnotation("surface",m,"STRING"),d.addBinaryAnnotation("isAuthenticated",v,"BOOL"),d.addBinaryAnnotation("scrollDuration",n,"I32"),d.addBinaryAnnotation("numberOfFrames",r,"I16"),d.stop(l))}window.cancelAnimationFrame(u),r=0,o=0,f=[],a=null,i=null,s=null},p=function(e){var t=e.timeStamp;n&&clearTimeout(n),n=setTimeout(d,500),null===s?(s=100*Math.random()<10)&&(u=window.requestAnimationFrame(l),i=t):s&&(a=t,r+=o,o=0)},m=function(e){var t=e.timeStamp;f.push(t)};["wheel","pointerdown","keydown"].forEach((function(e){window.addEventListener(e,m,{passive:!0,capture:!0})})),window.addEventListener("scroll",p,{passive:!0}),window.addEventListener("pagehide",(function(){window.removeEventListener("scroll",p),["wheel","pointerdown","keydown"].forEach((function(e){window.removeEventListener(e,m)}))}))}(s,(function(){return _(v.current)?_(v.current)||"UNKNOWN_SURFACE":v.current||"UNKNOWN_SURFACE"})),"Chrome"===s.browserName){h({staticContext:s,getCurrentRoute:function(){return v.current},getLastNavigationTime:function(){return l.current||0}});var e=_(v.current);e&&j({pwtStaticContext:s,surface:e})}}}),[]),d.current!==i){d.current=i,l.current=null!==(t=window.performance)&&void 0!==t&&t.now?window.performance.now():null;var y=l.current;if(!p.current){var w=!f.current;(0,T.A9)("routeStart",{tags:{action:u}}),(0,L.Eg)(w),(0,g.Ux)(w),(0,g.on)(),(0,A.tl)();var O=(0,L.LH)(),S=O.customBufferSize,E=O.defaultBufferSize;y&&((0,T.A9)("routeStart.customBufferSize",{count:S}),(0,T.A9)("routeStart.defaultBufferSize",{count:E}),f.current={time:y,action:u})}}return(0,k.jsx)(I.Provider,{value:b?s:null,children:(0,k.jsx)(x.Provider,{value:f.current,children:n})})}var Z=function(){return(0,r.useContext)(x)},B=function(){return(0,r.useContext)(I)}},576618:function(e,t,n){n.d(t,{D3:function(){return u},rX:function(){return s},jh:function(){return f},Hd:function(){return l}});var r=n(344120),o=n(641239);function i(e,t){var n=Object.keys(e);if(Object.getOwnPropertySymbols){var r=Object.getOwnPropertySymbols(e);t&&(r=r.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),n.push.apply(n,r)}return n}function a(e){for(var t=1;t<arguments.length;t++){var n=null!=arguments[t]?arguments[t]:{};t%2?i(Object(n),!0).forEach((function(t){c(e,t,n[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(n)):i(Object(n)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(n,t))}))}return e}function c(e,t,n){return t in e?Object.defineProperty(e,t,{value:n,enumerable:!0,configurable:!0,writable:!0}):e[t]=n,e}var u=function(e){return a(a({},(0,r.Z)(e)),{},{domComplete:e.domComplete||0,domContentLoadedEventEnd:e.domContentLoadedEventEnd||0,domContentLoadedEventStart:e.domContentLoadedEventStart||0,domInteractive:e.domInteractive||0,loadEventEnd:e.loadEventEnd||0,loadEventStart:e.loadEventStart||0})},s=function(){var e=(0,o.v2)(),t=e.firstInputDelay,n=e.largestContentfulPaint;return{firstInputDelayStart:(null==t?void 0:t.startTime)||0,firstInputDelayEnd:(null==t?void 0:t.endTime)||0,largestContentfulPaint:n||0}},f=function(e,t){return Object.keys(t).reduce((function(n,r){return a(a({},n),{},c({},"".concat(e).concat(r),t[r]))}),{})},l=function(e,t){return Object.keys(e).reduce((function(n,r){return t.includes(r)?a(a({},n),{},c({},r,e[r])):n}),Object.freeze({}))}},344120:function(e,t){t.Z=function(e){return{connectEnd:e.connectEnd||0,connectStart:e.connectStart||0,domainLookupEnd:e.domainLookupEnd||0,domainLookupStart:e.domainLookupStart||0,fetchStart:e.fetchStart||0,requestStart:e.requestStart||0,redirectEnd:e.redirectEnd||0,redirectStart:e.redirectStart||0,responseEnd:e.responseEnd||0,responseStart:e.responseStart||0,secureConnectionStart:e.secureConnectionStart||0,startTime:e.startTime||0,workerStart:e.workerStart||0,unloadEventStart:e.unloadEventStart||0,unloadEventEnd:e.unloadEventEnd||0}}},842310:function(e,t,n){n.d(t,{Z:function(){return c}});var r=n(590606),o=n(344120),i=n(447443),a=function(e){var t=e.category,n=e.isDeferred,r=e.isExternal;return[t].concat(n?["deferred"]:[]).concat(r?["external"]:[]).join("_")};function c(e,t){var n=e.category,c=e.timing,u=e.isDeferred,s=e.isExternal,f=e.isVisuallyCompleteRequired;return c.responseEnd&&("image"!==n||f)?{name:a(e),id:(0,r.Z)(),parentId:t,startTime:c.startTime,endTime:c.responseEnd,annotationMap:(0,o.Z)(c),binaryAnnotationMap:{category:(0,i.sk)(n),decodedBodySize:(0,i.cC)(c.decodedBodySize||0),initiatorType:(0,i.sk)(c.initiatorType),isDeferred:(0,i.qr)(u),isExternal:(0,i.qr)(s),name:(0,i.sk)(c.name),nextHopProtocol:(0,i.sk)(c.nextHopProtocol),transferSize:(0,i.cC)(c.transferSize||0)}}:null}},256721:function(e,t,n){n.d(t,{ku:function(){return Z},Jx:function(){return I},PY:function(){return R}});var r=n(954321),o=n(641239);function i(e,t){var n=Object.keys(e);if(Object.getOwnPropertySymbols){var r=Object.getOwnPropertySymbols(e);t&&(r=r.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),n.push.apply(n,r)}return n}function a(e){for(var t=1;t<arguments.length;t++){var n=null!=arguments[t]?arguments[t]:{};t%2?i(Object(n),!0).forEach((function(t){c(e,t,n[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(n)):i(Object(n)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(n,t))}))}return e}function c(e,t,n){return t in e?Object.defineProperty(e,t,{value:n,enumerable:!0,configurable:!0,writable:!0}):e[t]=n,e}var u=function(){return(0,o.PJ)().reduce((function(e,t){var n,r,o=t.identifier,i=t.loadTime,u=t.renderTime;return e["".concat(o,"_loadTime")]?e["".concat(o,"_dupe_loadTime")]?a(a({},e),{},(c(n={},"".concat(o,"_dupe_loadTime"),i),c(n,"".concat(o,"_dupe_renderTime"),u),n)):e:a(a({},e),{},(c(r={},"".concat(o,"_loadTime"),i),c(r,"".concat(o,"_renderTime"),u),r))}),Object.freeze({}))},s=n(344120),f=n(576618),l=n(133769),d=n(715930);function p(e,t){var n=Object.keys(e);if(Object.getOwnPropertySymbols){var r=Object.getOwnPropertySymbols(e);t&&(r=r.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),n.push.apply(n,r)}return n}function m(e){for(var t=1;t<arguments.length;t++){var n=null!=arguments[t]?arguments[t]:{};t%2?p(Object(n),!0).forEach((function(t){v(e,t,n[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(n)):p(Object(n)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(n,t))}))}return e}function v(e,t,n){return t in e?Object.defineProperty(e,t,{value:n,enumerable:!0,configurable:!0,writable:!0}):e[t]=n,e}var b=function(e){switch(e){case"pin_closeup":var t=(0,d.Z)();return n=[{name:"mainImage",match:function(e){return e.name===t}},{name:"PinResource",match:function(e){return e.name.includes("PinResource")}}],r=(0,l.y0)(),n.reduce((function(e,t){var n=t.name,o=t.match;return r.filter((function(e){return o(e)})).slice(0,2).reduce((function(e,t,r){return m(m({},e),(0,f.jh)("".concat(n).concat(r?"_dupe1":"","_"),(0,s.Z)(t)))}),e)}),Object.freeze({}));default:return{}}var n,r},y=n(403369),h=n(590606),g=n(299962),w=n(842310),O=n(182513),S=n(139585),E=n(940094),j=n(26382),_=n(939606);function P(e){return function(e){if(Array.isArray(e))return A(e)}(e)||function(e){if("undefined"!=typeof Symbol&&null!=e[Symbol.iterator]||null!=e["@@iterator"])return Array.from(e)}(e)||function(e,t){if(!e)return;if("string"==typeof e)return A(e,t);var n=Object.prototype.toString.call(e).slice(8,-1);"Object"===n&&e.constructor&&(n=e.constructor.name);if("Map"===n||"Set"===n)return Array.from(e);if("Arguments"===n||/^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(n))return A(e,t)}(e)||function(){throw new TypeError("Invalid attempt to spread non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method.")}()}function A(e,t){(null==t||t>e.length)&&(t=e.length);for(var n=0,r=new Array(t);n<t;n++)r[n]=e[n];return r}function C(e,t){var n=Object.keys(e);if(Object.getOwnPropertySymbols){var r=Object.getOwnPropertySymbols(e);t&&(r=r.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),n.push.apply(n,r)}return n}function T(e){for(var t=1;t<arguments.length;t++){var n=null!=arguments[t]?arguments[t]:{};t%2?C(Object(n),!0).forEach((function(t){L(e,t,n[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(n)):C(Object(n)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(n,t))}))}return e}function L(e,t,n){return t in e?Object.defineProperty(e,t,{value:n,enumerable:!0,configurable:!0,writable:!0}):e[t]=n,e}var D=(0,O.X)("LightStopwatch"),k={},I=function(e){var t=e.annotateExperiments,n=e.annotateMarks,o=e.annotateResourceTimingForSurface,i=e.name,a=e.pwtStaticContext,c=function(){var e=[],t=null;window.PerformanceObserver&&(t=(0,y.Z)({entryTypes:["resource"]},(function(t){(e=e.concat(t.getEntries())).length>1e3&&(e=e.slice(-1e3))})));return{get:function(){return e},disconnect:function(){t&&t.disconnect()}}}(),s=!0,l={};(0,_.A9)("TIMING.".concat(i),{tags:{isAuth:a.isAuthenticated}});var d={type:"stopwatch",name:i,navigationType:"initial_app_load"},p={abort:function(e){s?(s=!1,(0,g.Z)({metricId:d,pwtStaticContext:a,result:{type:"ABORT",reason:e}})):(0,_.H)("duplicate_abort_action",{action:i})},error:function(e,t){var n=T(T({},t),{},{action:i});s?(e&&(0,_.H)(e,n),c&&c.disconnect(),s=!1):(0,_.H)("duplicate_error_action",n)},stop:function(e){if(s){s=!1,c.disconnect();var p=(0,h.Z)(),m=(0,r.Z)(),v=c.get(),y={type:"COMPLETE",traceId:(0,h.Z)(),startTime:0,endTime:e,spans:[{name:"network_resources",id:p,startTime:0,endTime:e,annotationMap:{},binaryAnnotationMap:{},parentId:null}].concat(P(v.map((function(e){return(0,w.Z)((0,E.p)(e,[]),p)})).filter(Boolean))),annotationMap:T(T(T(T({},(0,f.jh)("resource_",o?b(o):{})),(0,f.jh)("element_",u())),(0,f.jh)("mark_",n&&n.length?(0,f.Hd)((0,S.gQ)(),n):{})),(0,f.jh)("browser_",m?(0,f.D3)(m):{})),binaryAnnotationMap:(0,j.n)({annotateExperiments:t,metricId:d,pwtStaticContext:a,performanceResourceTimings:v,binaryAnnotations:l})};(0,g.Z)({metricId:d,pwtStaticContext:a,result:y,isAuth:a.isAuthenticated})}else(0,_.H)("duplicate_stop_action",{action:i})},addBinaryAnnotation:function(e,t,n){D("adding binary annotation {".concat(e,": ").concat(String(t),"}")),l=T(T({},l),L({},e,{value:t,type:n}))}};return k[i]=p,p},x=function(e){return k[e]},R=function(e){return!!x(e)},Z=function(e){var t=e.stopwatchName,n=e.binaryAnnotationName,r=e.value,o=e.annotationType,i=x(t);i&&i.addBinaryAnnotation(n,r,o)}},715930:function(e,t,n){n.d(t,{f:function(){return r},Z:function(){return o}});var r="closeupImage",o=function(){if(!document.querySelector)return null;var e=document.querySelector('head>link[rel="preload"][as="image"][href^="https://i.pinimg.com/"]');return e instanceof HTMLLinkElement?e.href:null}},378956:function(e,t,n){n.d(t,{kz:function(){return g},Y:function(){return b},Tx:function(){return P},Tb:function(){return C}});var r,o,i,a,c=function(e,t){return{name:e,value:void 0===t?-1:t,delta:0,entries:[],id:"v2-".concat(Date.now(),"-").concat(Math.floor(8999999999999*Math.random())+1e12)}},u=function(e,t){try{if(PerformanceObserver.supportedEntryTypes.includes(e)){if("first-input"===e&&!("PerformanceEventTiming"in self))return;var n=new PerformanceObserver((function(e){return e.getEntries().map(t)}));return n.observe({type:e,buffered:!0}),n}}catch(e){}},s=function(e,t){var n=function n(r){"pagehide"!==r.type&&"hidden"!==document.visibilityState||(e(r),t&&(removeEventListener("visibilitychange",n,!0),removeEventListener("pagehide",n,!0)))};addEventListener("visibilitychange",n,!0),addEventListener("pagehide",n,!0)},f=function(e){addEventListener("pageshow",(function(t){t.persisted&&e(t)}),!0)},l=function(e,t,n){var r;return function(o){t.value>=0&&(o||n)&&(t.delta=t.value-(r||0),(t.delta||void 0===r)&&(r=t.value,e(t)))}},d=-1,p=function(){return"hidden"===document.visibilityState?0:1/0},m=function(){s((function(e){var t=e.timeStamp;d=t}),!0)},v=function(){return d<0&&(d=p(),m(),f((function(){setTimeout((function(){d=p(),m()}),0)}))),{get firstHiddenTime(){return d}}},b=function(e,t){var n,r=v(),o=c("FCP"),i=function(e){"first-contentful-paint"===e.name&&(s&&s.disconnect(),e.startTime<r.firstHiddenTime&&(o.value=e.startTime,o.entries.push(e),n(!0)))},a=performance.getEntriesByName&&performance.getEntriesByName("first-contentful-paint")[0],s=a?null:u("paint",i);(a||s)&&(n=l(e,o,t),a&&i(a),f((function(r){o=c("FCP"),n=l(e,o,t),requestAnimationFrame((function(){requestAnimationFrame((function(){o.value=performance.now()-r.timeStamp,n(!0)}))}))})))},y=!1,h=-1,g=function(e,t){y||(b((function(e){h=e.value})),y=!0);var n,r=function(t){h>-1&&e(t)},o=c("CLS",0),i=0,a=[],d=function(e){if(!e.hadRecentInput){var t=a[0],r=a[a.length-1];i&&e.startTime-r.startTime<1e3&&e.startTime-t.startTime<5e3?(i+=e.value,a.push(e)):(i=e.value,a=[e]),i>o.value&&(o.value=i,o.entries=a,n())}},p=u("layout-shift",d);p&&(n=l(r,o,t),s((function(){p.takeRecords().map(d),n(!0)})),f((function(){i=0,h=-1,o=c("CLS",0),n=l(r,o,t)})))},w={passive:!0,capture:!0},O=new Date,S=function(e,t){r||(r=t,o=e,i=new Date,_(removeEventListener),E())},E=function(){if(o>=0&&o<i-O){var e={entryType:"first-input",name:r.type,target:r.target,cancelable:r.cancelable,startTime:r.timeStamp,processingStart:r.timeStamp+o};a.forEach((function(t){t(e)})),a=[]}},j=function(e){if(e.cancelable){var t=(e.timeStamp>1e12?new Date:performance.now())-e.timeStamp;"pointerdown"==e.type?function(e,t){var n=function(){S(e,t),o()},r=function(){o()},o=function(){removeEventListener("pointerup",n,w),removeEventListener("pointercancel",r,w)};addEventListener("pointerup",n,w),addEventListener("pointercancel",r,w)}(t,e):S(t,e)}},_=function(e){["mousedown","keydown","touchstart","pointerdown"].forEach((function(t){return e(t,j,w)}))},P=function(e,t){var n,i=v(),d=c("FID"),p=function(e){e.startTime<i.firstHiddenTime&&(d.value=e.processingStart-e.startTime,d.entries.push(e),n(!0))},m=u("first-input",p);n=l(e,d,t),m&&s((function(){m.takeRecords().map(p),m.disconnect()}),!0),m&&f((function(){var i;d=c("FID"),n=l(e,d,t),a=[],o=-1,r=null,_(addEventListener),i=p,a.push(i),E()}))},A=new Set,C=function(e,t){var n,r=v(),o=c("LCP"),i=function(e){var t=e.startTime;t<r.firstHiddenTime&&(o.value=t,o.entries.push(e)),n()},a=u("largest-contentful-paint",i);if(a){n=l(e,o,t);var d=function(){A.has(o.id)||(a.takeRecords().map(i),a.disconnect(),A.add(o.id),n(!0))};["keydown","click"].forEach((function(e){addEventListener(e,d,{once:!0,capture:!0})})),s(d,!0),f((function(r){o=c("LCP"),n=l(e,o,t),requestAnimationFrame((function(){requestAnimationFrame((function(){o.value=performance.now()-r.timeStamp,A.add(o.id),n(!0)}))}))}))}}}}]);
//# sourceMappingURL=https://sm.pinimg.com/webapp/12587-ac1de94caff9d740.js.map