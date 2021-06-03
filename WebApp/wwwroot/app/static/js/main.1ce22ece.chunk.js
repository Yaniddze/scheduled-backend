(this.webpackJsonpschedulefront=this.webpackJsonpschedulefront||[]).push([[0],{263:function(n,e,t){"use strict";t.r(e);var r,o=t(0),c=t(21),a=t.n(c),i=t(43),s=t(12),l=t(11),d=Object(l.b)(r||(r=Object(s.a)(["\n    body, html, #root, #app {\n        margin: 0;\n        padding: 0;\n\n        height: 100%;\n        font-family: 'Roboto', sans-serif;\n    }\n\n    #app {\n        display: grid;\n\n        grid-template-rows: 100px 1fr 200px;\n    }\n\n    #app:first-child {\n        grid-row-start: 1; \n    }\n\n    #app:nth-child(2) {\n        grid-row-start: 2;\n    }\n\n    #app:last-child {\n        grid-row-start: 3;\n    }\n\n    a{\n        text-decoration: none;\n        color: inherit;\n    }\n    a:visited {\n        color: currentColor;\n    }\n\n\n    /* prepared animations*/\n    .fade-enter{\n    opacity: 0;\n    transform: translateX(-100%);\n    }\n    .fade-exit{\n        opacity: 1;\n        transform: translateX(0);\n    }\n    .fade-enter-active{\n        opacity: 1;\n        opacity: 1;\n        transform: translateX(0);\n    }\n    .fade-exit-active{\n        opacity: 0;\n        opacity: 0;\n        transform: translateX(-100%);\n    }\n    .fade-enter-active,\n    .fade-exit-active{\n        transition: opacity 0.3s, transform 0.3s;\n    }\n"]))),u=t(81),h=t(63),j=t(157),b="UPDATE_TOKEN";var p="UPDATE_TEMP";var x=t(25),f="ADD_GROUP";var g,O,m,v,w,k,y,C,S,T,F,_,E,D,R,A=Object(h.c)({token:function(){var n=arguments.length>0&&void 0!==arguments[0]?arguments[0]:localStorage.getItem("user_token")||"",e=arguments.length>1?arguments[1]:void 0;return e.type===b?(localStorage.setItem("user_token",e.payload),e.payload):n},temp:function(){var n=arguments.length>0&&void 0!==arguments[0]?arguments[0]:new Date,e=arguments.length>1?arguments[1]:void 0;return e.type===p?e.payload:n},group:function(){var n=arguments.length>0&&void 0!==arguments[0]?arguments[0]:[],e=arguments.length>1?arguments[1]:void 0;return e.type===f?[].concat(Object(x.a)(n.filter((function(n){return n.id!=e.payload.id}))),[e.payload]):n}}),L="object"===typeof window&&window.__REDUX_DEVTOOLS_EXTENSION_COMPOSE__?window.__REDUX_DEVTOOLS_EXTENSION_COMPOSE__({}):h.d,N=Object(h.e)(A,L(Object(h.a)(j.a))),P=t(2),U=function(n){var e=n.children;return Object(P.jsx)(u.a,{store:N,children:e})},W=t(20),I=t(293),M=t(294),X=t(295),V=t(290),B=function(n){var e=n.children;return Object(P.jsx)(V.a,{maxWidth:"lg",children:e})},q=l.c.div(g||(g=Object(s.a)(["\n    background: ",";\n    color: ",";\n\n    > * {\n        height: 100%;\n        > * {\n            height: 100%;\n        }\n    }\n"])),(function(n){return n.theme.colors.background.header.color}),(function(n){return n.theme.colors.background.header.contrast})),z=l.c.div(O||(O=Object(s.a)(["\n    display: flex;\n    margin: auto 0;\n\n    > div {\n        display: flex;\n        gap: 0 15px;\n        width: 100%;\n    }\n"]))),G=l.c.div(m||(m=Object(s.a)(["\n    margin: auto 0;\n\n    > * {\n        color: ",";\n        text-decoration: none;\n        display: flex;\n        text-align: center;\n\n        > * {\n            margin: auto 0;\n        }\n    }\n"])),(function(n){return n.theme.colors.background.header.contrast})),Y=l.c.div(v||(v=Object(s.a)(["\n    width: 80px;\n    svg {\n        width: 100%;\n        height: 100%;\n    }\n"]))),J=function(){var n=Object(W.g)();return Object(P.jsx)(q,{children:Object(P.jsx)(B,{children:Object(P.jsx)(z,{children:Object(P.jsxs)("div",{children:[Object(P.jsx)(Y,{children:Object(P.jsx)(I.a,{})}),Object(P.jsx)(K,{currentRoute:n.pathname,route:"/groups",children:Object(P.jsxs)(P.Fragment,{children:[Object(P.jsx)(M.a,{})," ",Object(P.jsx)("span",{children:"\u0413\u0440\u0443\u043f\u043f\u044b"})]})}),Object(P.jsx)(K,{currentRoute:n.pathname,route:"/account",children:Object(P.jsxs)(P.Fragment,{children:[Object(P.jsx)(X.a,{})," ",Object(P.jsx)("span",{children:"\u0410\u043a\u043a\u0430\u0443\u043d\u0442"})]})})]})})})})},K=function(n){var e=n.children,t=n.currentRoute,r=n.route;return Object(P.jsx)(G,{children:t===r?Object(P.jsx)("div",{children:e}):Object(P.jsxs)(i.b,{to:r,children:[" ",e," "]})})},Z=t(307),Q=t(161),$=t.n(Q),H=t(162),nn=t.n(H),en=t(163),tn=t.n(en),rn=t(164),on=t.n(rn),cn=t(165),an=t.n(cn),sn=l.c.div(w||(w=Object(s.a)(["\n  display: flex;\n  justify-content: center;\n  gap: 0 50px;\n\n  @media (max-width: 420px) {\n    gap: 0 25px;\n  }\n"]))),ln=l.c.div(k||(k=Object(s.a)(["\n    background: ",";\n    color: ",";\n"])),(function(n){return n.theme.colors.background.footer.color}),(function(n){return n.theme.colors.background.footer.contrast})),dn=function(){return Object(P.jsx)(ln,{children:Object(P.jsx)(B,{children:Object(P.jsx)(Z.a,{display:"flex",justifyContent:"center",alignItems:"center",mt:5,children:Object(P.jsxs)("div",{children:['\u041a\u0443\u0440\u0441\u043e\u0432\u0430\u044f \u0440\u0430\u0431\u043e\u0442\u0430 - "\u0420\u0430\u0441\u043f\u0438\u0441\u0430\u043d\u0438\u0435 \u043e\u0440\u043a\u043e\u0432\u0441\u043a\u043e\u0435"',Object(P.jsx)(Z.a,{textAlign:"center",mt:2,mb:2,children:"\xa9 \u0417\u0438\u043d\u0435\u0432\u0438\u0447 \u042f\u043d 2021"}),Object(P.jsxs)(sn,{children:[Object(P.jsx)("a",{href:"https://github.com/Yaniddze",children:Object(P.jsx)($.a,{})}),Object(P.jsx)("a",{href:"https://www.youtube.com/channel/UCSBSAK98S9VbQpEiZAVU8Bg",children:Object(P.jsx)(nn.a,{})}),Object(P.jsx)("a",{href:"mailto:yanrus09@gmail.com",children:Object(P.jsx)(tn.a,{})}),Object(P.jsx)("a",{href:"https://twitter.com/Yaniddze",children:Object(P.jsx)(on.a,{})}),Object(P.jsx)("a",{href:"https://t.me/Yaniddze",children:Object(P.jsx)(an.a,{})})]})]})})})})},un=t(28),hn=l.c.input(y||(y=Object(s.a)(['\n  position: relative;\n  width: 60px;\n  height: 30px;\n  -webkit-appearance: none;\n  background: #bbb;\n  border-radius: 15px;\n  box-shadow: 0 0 20px rgba(0,0,0,.2);\n  outline: none;\n  transition: all .2s ease;\n  \n  &:before {\n    content: "";\n    position: absolute;\n    width: 30px;\n    height: 30px;\n    border-radius: 20px;\n    transform: scale(1.2);\n    background: white;\n    left: 0;\n    transition: all .2s ease;\n  }\n  \n  &:checked:before {\n    left: 30px;\n  }\n']))),jn=function(n){var e=n.initValue,t=n.handleChange,r=Object(o.useState)(e),c=Object(un.a)(r,2),a=c[0],i=c[1];return Object(P.jsx)(hn,{checked:a,type:"checkbox",onChange:function(){i((function(n){return!n})),t()}})},bn=t(296),pn=function(n){var e=n.variant,t=n.color,r=n.onClick,o=n.children;return Object(P.jsx)(bn.a,{variant:void 0===e?"contained":e,color:void 0===t?"primary":t,onClick:r,children:o})},xn=l.c.div(C||(C=Object(s.a)(["\n    background: ",";\n    color: ",";\n"])),(function(n){return n.theme.colors.background.main.color}),(function(n){return n.theme.colors.background.main.contrast})),fn=l.c.div(S||(S=Object(s.a)(["\n    border-radius: 20px;\n    height: 100%;\n    width: 100%;\n    margin: 10px 0;\n"]))),gn=function(n){var e=n.children;return Object(P.jsx)(xn,{children:Object(P.jsx)(B,{children:Object(P.jsx)(fn,{children:e})})})},On=t(97),mn=t(265),vn=t(305),wn=l.c.div(T||(T=Object(s.a)(["\n  border-radius: 6px;\n  background-color: #819ca9;\n\n  padding: 16px;\n"]))),kn=l.c.div(F||(F=Object(s.a)(["\n  margin: 15px 0;\n"]))),yn=function(n){return Object(P.jsx)(wn,{children:n.children})},Cn=function(n){var e,t,r=n.onSubmit,o=n.error,c=Object(On.a)(),a=c.register,i=c.handleSubmit,s=c.errors;return Object(P.jsxs)(yn,{children:[Object(P.jsx)(mn.a,{align:"center",variant:"h4",children:"\u0412\u0445\u043e\u0434"}),Object(P.jsxs)("div",{children:[Object(P.jsx)("div",{style:{color:"red"},children:o}),Object(P.jsx)(kn,{children:Object(P.jsx)(vn.a,{name:"login",inputRef:a({required:{value:!0,message:"\u042d\u0442\u043e \u043f\u043e\u043b\u0435 \u043e\u0431\u044f\u0437\u0430\u0442\u0435\u043b\u044c\u043d\u043e"}}),label:"\u041b\u043e\u0433\u0438\u043d",fullWidth:!0,error:!!s.login,helperText:null===(e=s.login)||void 0===e?void 0:e.message})}),Object(P.jsx)(kn,{children:Object(P.jsx)(vn.a,{name:"password",type:"password",inputRef:a({required:{value:!0,message:"\u042d\u0442\u043e \u043f\u043e\u043b\u0435 \u043e\u0431\u044f\u0437\u0430\u0442\u0435\u043b\u044c\u043d\u043e"}}),label:"\u043f\u0430\u0440\u043e\u043b\u044c",fullWidth:!0,error:!!s.password,helperText:null===(t=s.password)||void 0===t?void 0:t.message})})]}),Object(P.jsx)("div",{children:Object(P.jsx)(pn,{onClick:i(r),color:"primary",children:"\u0412\u043e\u0439\u0442\u0438"})})]})},Sn=l.c.div(_||(_=Object(s.a)(["\n  background-color: ",";\n  color: ",";\n\n  border-radius: 6px;\n  padding: 16px;\n  box-shadow: 0 0 5px 0 #000;\n\n  cursor: pointer;\n  transition: box-shadow 0.3s;\n\n  &:hover {\n    box-shadow: 0 0 15px 2px #111;\n  }\n"])),(function(n){return n.theme.colors.palette.layout.main.color}),(function(n){return n.theme.colors.palette.layout.main.textColor})),Tn=function(n){var e=n.group,t=n.to;return Object(P.jsx)(i.b,{to:t,children:Object(P.jsx)(Sn,{children:Object(P.jsx)("h3",{children:e.name})})})},Fn=l.c.div(E||(E=Object(s.a)(["\n  background-color: ",";\n  color: ",";\n  border-bottom: 2px solid ",";\n\n  border-radius: 8px;\n  padding: 8px;\n\n  display: flex;\n  justify-content: space-between;\n\n  .lesson-info {\n    display: inline-block;\n    padding: 8px;\n    background-color: ",";\n    font-weight: bold;\n    color: #333;\n    border-radius: 8px;\n    box-shadow: 0 0 6px #333;\n\n    span:not(:last-child) {\n      margin-right: 10px;\n    }\n  }\n\n  .delete-icon {\n    color: #d46087;\n    stroke: black;\n  }\n"])),(function(n){return n.theme.colors.palette.layout.main.color}),(function(n){return n.theme.colors.palette.layout.main.textColor}),(function(n){return n.theme.colors.main.color}),(function(n){return n.theme.colors.palette.layout.main.textColor})),_n=function(n){var e=n.lesson,t=new Date(e.time);return t.setMinutes(t.getMinutes()+e.duration),Object(P.jsx)(Fn,{children:Object(P.jsxs)("div",{children:[Object(P.jsx)("h3",{children:e.name}),Object(P.jsxs)("div",{className:"lesson-info",children:[Object(P.jsx)("span",{children:e.teacher}),Object(P.jsxs)("span",{children:[e.time.toLocaleTimeString("ru-RU",{hour:"2-digit",minute:"2-digit"})," - ",t.toLocaleTimeString("ru-RU",{hour:"2-digit",minute:"2-digit"})]})]})]})})},En=(t(73),l.c.div(D||(D=Object(s.a)(["\n  .lesson-add {\n    position: relative;\n    padding: 12px;\n    border-radius: 8px;\n    border: 3px solid #fff;\n    margin-top: 15px;\n    box-shadow: 0 0 8px 0 #333;\n    transition: box-shadow 0.3s;\n    overflow: hidden;\n    padding-bottom: 60px;\n\n    &:hover {\n      box-shadow: 0 0 8px 3px #333;\n    }\n  }\n\n  .lesson-add__info {\n    display: flex;\n    gap: 10px 15px;\n    flex-wrap: wrap;\n  }\n\n  .lesson-add-button {\n    z-index: 1;\n    text-align: center;\n    position: absolute;\n    height: 100%;\n    width: 100%;\n    left: 0;\n    top: 0; \n    display: flex;\n    align-items: center;\n    justify-content: center;\n    background-color: #eee;\n    border-radius: 4px;\n    cursor: pointer;\n    transition: top 0.3s;\n  }\n\n  .lesson-add.edit .lesson-add-button {\n    top: calc(100% - 45px);\n    align-items: flex-start;\n\n    svg {\n      transform: rotateZ(45deg);\n      transition: transform 0.3s;\n    }\n  }\n"]))),t(27),t(304),t(166),t(186),t(308),t(187),t(301)),Dn=t(302),Rn=t(317),An=function(n){var e,t,r,o=n.onSubmit,c=n.error,a=Object(On.a)(),i=a.register,s=a.handleSubmit,l=a.errors,d=a.getValues;return Object(P.jsxs)(yn,{children:[Object(P.jsx)(mn.a,{align:"center",variant:"h4",children:"\u0420\u0435\u0433\u0438\u0441\u0442\u0440\u0430\u0446\u0438\u044f"}),Object(P.jsx)("div",{style:{color:"red"},children:c}),Object(P.jsx)(kn,{children:Object(P.jsx)(vn.a,{name:"login",inputRef:i({required:{value:!0,message:"\u042d\u0442\u043e \u043f\u043e\u043b\u0435 \u043e\u0431\u044f\u0437\u0430\u0442\u0435\u043b\u044c\u043d\u043e"},minLength:{value:4,message:"\u041c\u0438\u043d\u0438\u043c\u0430\u043b\u044c\u043d\u0430\u044f \u0434\u043b\u0438\u043d\u043d\u0430 \u043f\u043e\u043b\u044f - 4 \u0441\u0438\u043c\u0432\u043e\u043b\u0430"},maxLength:{value:20,message:"\u041c\u0430\u043a\u0441\u0438\u043c\u0430\u043b\u044c\u043d\u0430\u044f \u0434\u043b\u0438\u043d\u043d\u0430 \u043f\u043e\u043b\u044f - 20 \u0441\u0438\u043c\u0432\u043e\u043b\u043e\u0432"}}),label:"\u041b\u043e\u0433\u0438\u043d",fullWidth:!0,error:!!l.login,helperText:null===(e=l.login)||void 0===e?void 0:e.message})}),Object(P.jsx)(kn,{children:Object(P.jsx)(vn.a,{name:"password",type:"password",inputRef:i({required:{value:!0,message:"\u042d\u0442\u043e \u043f\u043e\u043b\u0435 \u043e\u0431\u044f\u0437\u0430\u0442\u0435\u043b\u044c\u043d\u043e"},minLength:{value:4,message:"\u041c\u0438\u043d\u0438\u043c\u0430\u043b\u044c\u043d\u0430\u044f \u0434\u043b\u0438\u043d\u043d\u0430 \u043f\u043e\u043b\u044f - 4 \u0441\u0438\u043c\u0432\u043e\u043b\u0430"},maxLength:{value:20,message:"\u041c\u0430\u043a\u0441\u0438\u043c\u0430\u043b\u044c\u043d\u0430\u044f \u0434\u043b\u0438\u043d\u043d\u0430 \u043f\u043e\u043b\u044f - 20 \u0441\u0438\u043c\u0432\u043e\u043b\u043e\u0432"}}),label:"\u043f\u0430\u0440\u043e\u043b\u044c",fullWidth:!0,error:!!l.password,helperText:null===(t=l.password)||void 0===t?void 0:t.message})}),Object(P.jsx)(kn,{children:Object(P.jsx)(vn.a,{name:"repeatPassword",type:"password",inputRef:i({required:{value:!0,message:"\u042d\u0442\u043e \u043f\u043e\u043b\u0435 \u043e\u0431\u044f\u0437\u0430\u0442\u0435\u043b\u044c\u043d\u043e"},validate:function(n){return d().password===n||"\u041f\u0430\u0440\u043e\u043b\u0438 \u0434\u043e\u043b\u0436\u043d\u044b \u0441\u043e\u0432\u043f\u0430\u0434\u0430\u0442\u044c"}}),label:"\u041f\u043e\u0432\u0442\u043e\u0440\u0438\u0442\u0435 \u043f\u0430\u0440\u043e\u043b\u044c",fullWidth:!0,error:!!l.repeatPassword,helperText:null===(r=l.repeatPassword)||void 0===r?void 0:r.message})}),Object(P.jsx)("div",{children:Object(P.jsx)(bn.a,{onClick:s(o),color:"primary",variant:"contained",children:"\u0417\u0430\u0440\u0435\u0433\u0438\u0441\u0442\u0440\u0438\u0440\u043e\u0432\u0430\u0442\u044c\u0441\u044f"})})]})},Ln=l.c.div(R||(R=Object(s.a)(["\n  max-width: 550px;\n  margin: 0 auto;\n  padding: 8px;\n\n  background-color: #cfd8dc;\n  border-radius: 8px;\n  box-shadow: 0 0 6px 0 #000;\n\n  .auth-page__toggler {\n    color: #263238;\n  }\n"]))),Nn=t(300),Pn=t(311),Un=function(){var n=Object(u.c)((function(n){return n.token})),e=Object(u.b)();return{token:n,setToken:function(n){e(function(n){return{type:b,payload:n}}(n))}}},Wn=t(19),In=t.n(Wn),Mn=t(29),Xn=t(310),Vn=t(94),Bn=t(188),qn=t(118),zn=t.n(qn);var Gn=function(){function n(e,t){var r=this;Object(Vn.a)(this,n),this.httpClient=void 0,this.canceller=void 0,this.Fetch=void 0;var o=function(n){var e,t=new zn.a.CancelToken((function(n){e=n}));return{httpClient:zn.a.create({baseURL:"/api/v1",cancelToken:t,withCredentials:!0,headers:{Authorization:"Bearer ".concat(n)}}),canceler:e}}(t);this.httpClient=o.httpClient,this.canceller=o.canceler,this.Fetch=function(){var n=Object(Mn.a)(In.a.mark((function n(t){return In.a.wrap((function(n){for(;;)switch(n.prev=n.next){case 0:return n.next=2,e(r.httpClient,t);case 2:return n.abrupt("return",n.sent.data);case 3:case"end":return n.stop()}}),n)})));return function(e){return n.apply(this,arguments)}}()}return Object(Bn.a)(n,[{key:"Cancel",value:function(){void 0!==this.canceller&&this.canceller()}}]),n}(),Yn=function(n,e){return n.post("/account/login",e)},Jn=function(n,e){return n.post("/account/register",e)},Kn=function(n){return n.get("/group")},Zn=function(n,e){return n.post("/group/detailed",e)},Qn=function(n,e){return n.get("/scheduled?groupId=".concat(e.groupId,"&date=").concat(e.startDate))};function $n(n,e,t){var r=Un().token,c=Object(o.useRef)(new Gn(e,r)).current;return Object(Xn.a)(n,Object(Mn.a)(In.a.mark((function n(){var e;return In.a.wrap((function(n){for(;;)switch(n.prev=n.next){case 0:return n.next=2,c.Fetch(t);case 2:if((e=n.sent).succeeded){n.next=5;break}throw new Error(e.errorMessage);case 5:return n.abrupt("return",e.data);case 6:case"end":return n.stop()}}),n)}))))}var Hn=t(313);function ne(n,e){var t=Un().token,r=Object(o.useRef)(new Gn(e,t)).current;return Object(Hn.a)(n,function(){var n=Object(Mn.a)(In.a.mark((function n(e){var t;return In.a.wrap((function(n){for(;;)switch(n.prev=n.next){case 0:return n.next=2,r.Fetch(e);case 2:if((t=n.sent).succeeded){n.next=5;break}throw new Error(t.errorMessage);case 5:return n.abrupt("return",t.data);case 6:case"end":return n.stop()}}),n)})));return function(e){return n.apply(this,arguments)}}())}var ee,te,re,oe,ce,ae,ie,se=function(){var n=Object(o.useState)(!0),e=Object(un.a)(n,2),t=e[0],r=e[1],c=Un().setToken,a=ne("login",Yn),i=a.mutate,s=a.data,l=a.error,d=ne("register",Jn),u=d.mutate,h=d.data,j=d.error;(null===s||void 0===s?void 0:s.token)&&c(s.token),(null===h||void 0===h?void 0:h.token)&&c(h.token);return Object(P.jsxs)(Ln,{children:[Object(P.jsx)(Nn.a,{children:Object(P.jsx)(Pn.a,{addEndListener:function(n,e){return n.addEventListener("transitionend",e,!1)},classNames:"fade",children:t?Object(P.jsx)(Cn,{onSubmit:function(n){i({username:n.login,password:n.password})},error:(null===l||void 0===l?void 0:l.message)||""}):Object(P.jsx)(An,{onSubmit:function(n){u({username:n.login,password:n.password})},error:(null===j||void 0===j?void 0:j.message)||""})},t?"login":"registration")}),Object(P.jsx)(Z.a,{marginTop:1,mb:1,children:Object(P.jsx)(En.a,{})}),Object(P.jsx)("div",{className:"auth-page__toggler",children:Object(P.jsx)(Dn.a,{control:Object(P.jsx)(Rn.a,{checked:t,onChange:function(n,e){r(e)},name:"checkedA",inputProps:{"aria-label":"secondary checkbox"}}),label:t?"\u0417\u0430\u0440\u0435\u0433\u0438\u0441\u0442\u0440\u0438\u0440\u043e\u0432\u0430\u0442\u044c\u0441\u044f":"\u0412\u043e\u0439\u0442\u0438"})})]})},le=l.c.div(ee||(ee=Object(s.a)(["\n  display: grid;\n  grid-template-columns: repeat(auto-fill, minmax(150px, 1fr));\n  grid-auto-rows: 93px;\n  gap: 15px;\n\n  .--red-button {\n    background-color: #ffc107;\n\n    &:hover {\n      background-color: #ff8f00;\n    }\n  }\n"]))),de=l.c.div(te||(te=Object(s.a)(["\n  display: grid;\n  grid-template-columns: repeat(auto-fill, minmax(150px, 1fr));\n  gap: 15px;\n"]))),ue=l.c.div(re||(re=Object(s.a)(["\n  background: linear-gradient(-60deg, #bdbdbd 57%, #fff 60%, #bdbdbd 62%);\n  background-position: 0px;\n  border-radius: 6px;\n  height: 93px;\n  animation: GroupSceletonCard 0.5s infinite forwards linear;\n\n  &:hover {\n    background-position: 50%;\n  }\n\n  @keyframes GroupSceletonCard {\n    from{\n      background-position: 0px;\n    }\n    to{ \n      background-position: 150px;\n    }\n  }\n"]))),he=function(n){for(var e=n.count,t=void 0===e?8:e,r=[],o=0;o<t;o++)r.push(Object(P.jsx)(ue,{},o));return Object(P.jsx)(de,{children:r})},je=function(){var n=$n("groups",Kn,void 0),e=n.data;return n.isFetching?Object(P.jsx)(he,{count:6}):Object(P.jsx)(le,{children:null===e||void 0===e?void 0:e.map((function(n){return Object(P.jsx)(Tn,{to:"/schedule/".concat(n.id),group:n},n.id)}))})},be=Object(l.c)(i.b)(oe||(oe=Object(s.a)(["\n  display: block;\n  background-color: ",";\n  color: ",";\n\n  border-radius: 8px;\n  padding: 16px;\n  margin: 10px 0;\n"])),(function(n){return n.theme.colors.palette.layout.main.color}),(function(n){return n.theme.colors.palette.layout.main.textColor})),pe=function(){var n=Object(W.h)().id,e=$n("detailedGroup-".concat(n),Zn,{id:Number(n)}).data,t=null===e||void 0===e?void 0:e.tasks.map((function(e){var t=e.date.split("-");return Object(P.jsx)(be,{to:"/schedule/".concat(n,"/").concat(e.date),children:Object(P.jsx)("h3",{children:new Date(Number(t[2]),Number(t[1])-1,Number(t[0])).toLocaleDateString("ru-RU")})},e.date)}));return null===t||void 0===t||t.reverse(),Object(P.jsxs)("div",{children:[t,0===(null===t||void 0===t?void 0:t.length)?"\u041f\u0440\u0435\u0434\u043c\u0435\u0442\u043e\u0432 \u043d\u0435\u0442":""]})},xe=l.c.div(ce||(ce=Object(s.a)(["\n  background-color: ",";\n  color: ",";\n\n  border-radius: 8px;\n  padding: 8px;\n"])),(function(n){return n.theme.colors.palette.layout.main.color}),(function(n){return n.theme.colors.palette.layout.main.textColor})),fe=function n(e,t,r,o,c){Object(Vn.a)(this,n),this.time=new Date,this.teacher="",this.name="",this.duration=90,this.id=0,this.name=e,this.teacher=t,this.time=r,this.duration=o,this.id=c},ge=function(n){var e=Object(W.h)(),t=e.id,r=e.day,o=$n("schedule-".concat(t,"-").concat(r),Qn,{startDate:r,groupId:t}).data;return Object(P.jsxs)(xe,{children:[0==(null===o||void 0===o?void 0:o.length)&&Object(P.jsx)("p",{children:"\u0417\u0430\u043d\u044f\u0442\u0438\u0439 \u043d\u0435\u0442."}),null===o||void 0===o?void 0:o.map((function(n,e){var t=new fe(n.subjectName,n.teacher,new Date(n.startDate),n.durationInMinutes,n.id);return Object(P.jsx)(_n,{lesson:t},e)}))]})},Oe=l.c.div(ae||(ae=Object(s.a)(["\n  background-color: ",";\n  color: ",";\n\n  border-radius: 6px;\n  padding: 16px;\n  box-shadow: 0 0 5px 0 #000;\n"])),(function(n){return n.theme.colors.palette.layout.main.color}),(function(n){return n.theme.colors.palette.layout.main.textColor})),me=function(n){var e=n.children;return Object(P.jsx)(Oe,{children:e})},ve=function(n){var e=Un().setToken;return Object(P.jsxs)(me,{children:[Object(P.jsx)("h3",{children:"\u0410\u043a\u043a\u0430\u0443\u043d\u0442"}),Object(P.jsx)(bn.a,{variant:"contained",color:"primary",onClick:function(){return e("")},children:"\u0412\u044b\u0439\u0442\u0438"})]})},we=function(n){var e=n.children,t=n.validation,r=n.redirect;return t(Un().token)?e:Object(P.jsx)(W.a,{to:String(r)})},ke=function(){return Object(P.jsxs)(W.d,{children:[Object(P.jsx)(W.b,{path:"/schedule",exact:!0,children:Object(P.jsx)(Se,{children:Object(P.jsx)(je,{})})}),Object(P.jsx)(W.b,{path:"/account",exact:!0,children:Object(P.jsx)(Se,{children:Object(P.jsx)(ve,{})})}),Object(P.jsx)(W.b,{path:"/login",exact:!0,children:Object(P.jsx)(Te,{children:Object(P.jsx)(se,{})})}),Object(P.jsx)(W.b,{path:"/schedule/:id",exact:!0,children:Object(P.jsx)(Se,{children:Object(P.jsx)(pe,{})})}),Object(P.jsx)(W.b,{path:"/schedule/:id/:day",exact:!0,children:Object(P.jsx)(Se,{children:Object(P.jsx)(ge,{})})}),Object(P.jsx)(W.a,{to:"/schedule"})]})},ye=function(n){return n.length>0},Ce=function(n){return 0===n.length},Se=function(n){return Object(P.jsx)(we,{validation:ye,redirect:"/login",children:n.children})},Te=function(n){return Object(P.jsx)(we,{validation:Ce,redirect:"/",children:n.children})},Fe=t(100),_e=t.n(Fe),Ee=t(189),De=t(303),Re={colors:{main:{color:"#62E200",contrast:"#000"},secondary:{color:"#62AA2A",contrast:"#000"},background:{header:{color:"#e1e3e6",contrast:"#000"},footer:{color:"#5c5c63",contrast:"#FFF"},main:{color:"#FFF",contrast:"#000"}},calcDarkInRgba:function(n){return"rgba(64,147,0,".concat(n,")")},error:{color:"#f00",contrast:"#000"},linkColor:{color:"#000",contrast:"#000"},palette:{layout:{contrast:{color:"#263238",textColor:"#fff"},main:{color:"#78909c",textColor:"#fff"},100:{color:"#cfd8dc",textColor:"#333"},900:{color:"#263238",textColor:"#fff"}}}}},Ae={colors:{main:{color:"#62E200",contrast:"#000"},secondary:{color:"#62AA2A",contrast:"#000"},background:{header:{color:"#383b40",contrast:"#FFF"},footer:{color:"#010101",contrast:"#FFF"},main:{color:"#27292D",contrast:"#FFF"}},calcDarkInRgba:function(n){return"rgba(64,147,0,".concat(n,")")},error:{color:"#f00",contrast:"#000"},linkColor:{color:"#000",contrast:"#000"},palette:{layout:{contrast:{color:"#263238",textColor:"#fff"},main:{color:"#78909c",textColor:"#fff"},100:{color:"#cfd8dc",textColor:"#333"},900:{color:"#263238",textColor:"#fff"}}}}},Le=l.c.div(ie||(ie=Object(s.a)(["\n    position: absolute;\n    top: 0;\n    right: 0;\n    margin: 10px;\n"]))),Ne="Schedule.Theme",Pe="light"===_e.a.get(Ne),Ue=function(n){var e=n.children,t=Object(o.useState)(Pe?Re:Ae),r=Object(un.a)(t,2),c=r[0],a=r[1];return Object(P.jsx)(P.Fragment,{children:Object(P.jsx)(l.a,{theme:c,children:Object(P.jsxs)(We,{children:[Object(P.jsx)(Le,{children:Object(P.jsx)(jn,{initValue:!Pe,handleChange:function(){a((function(n){return n===Re?(_e.a.set(Ne,"dark"),Ae):(_e.a.set(Ne,"light"),Re)}))}})}),e]})})})},We=function(n){var e=n.children,t=Object(l.d)(),r=Object(Ee.a)({palette:{primary:{main:t.colors.main.color,contrastText:t.colors.main.contrast},secondary:{main:t.colors.secondary.color,contrastText:t.colors.secondary.contrast}}});return Object(P.jsx)(De.a,{theme:r,children:e})},Ie=t(309),Me=t(95),Xe=new Ie.a,Ve=function(n){return Object(P.jsx)(Me.a,{client:Xe,children:n.children})},Be=function(){return Object(P.jsx)(i.a,{children:Object(P.jsx)(Ve,{children:Object(P.jsxs)(U,{children:[Object(P.jsx)(Ue,{children:Object(P.jsxs)("div",{id:"app",children:[Object(P.jsx)(J,{}),Object(P.jsx)(gn,{children:Object(P.jsx)(ke,{})}),Object(P.jsx)(dn,{})]})}),Object(P.jsx)(d,{})]})})})},qe=function(n){n&&n instanceof Function&&t.e(3).then(t.bind(null,318)).then((function(e){var t=e.getCLS,r=e.getFID,o=e.getFCP,c=e.getLCP,a=e.getTTFB;t(n),r(n),o(n),c(n),a(n)}))},ze=Boolean("localhost"===window.location.hostname||"[::1]"===window.location.hostname||window.location.hostname.match(/^127(?:\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}$/));function Ge(n,e){navigator.serviceWorker.register(n).then((function(n){n.onupdatefound=function(){var t=n.installing;null!=t&&(t.onstatechange=function(){"installed"===t.state&&(navigator.serviceWorker.controller?(console.log("New content is available and will be used when all tabs for this page are closed. See https://cra.link/PWA."),e&&e.onUpdate&&e.onUpdate(n)):(console.log("Content is cached for offline use."),e&&e.onSuccess&&e.onSuccess(n)))})}})).catch((function(n){console.error("Error during service worker registration:",n)}))}a.a.render(Object(P.jsx)(o.StrictMode,{children:Object(P.jsx)(Be,{})}),document.getElementById("root")),function(n){if("serviceWorker"in navigator){if(new URL("/app",window.location.href).origin!==window.location.origin)return;window.addEventListener("load",(function(){var e="".concat("/app","/service-worker.js");ze?(!function(n,e){fetch(n,{headers:{"Service-Worker":"script"}}).then((function(t){var r=t.headers.get("content-type");404===t.status||null!=r&&-1===r.indexOf("javascript")?navigator.serviceWorker.ready.then((function(n){n.unregister().then((function(){window.location.reload()}))})):Ge(n,e)})).catch((function(){console.log("No internet connection found. App is running in offline mode.")}))}(e,n),navigator.serviceWorker.ready.then((function(){console.log("This web app is being served cache-first by a service worker. To learn more, visit https://cra.link/PWA")}))):Ge(e,n)}))}}(),qe()}},[[263,1,2]]]);
//# sourceMappingURL=main.1ce22ece.chunk.js.map