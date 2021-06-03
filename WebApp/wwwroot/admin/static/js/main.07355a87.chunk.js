(this.webpackJsonpreactadminnet=this.webpackJsonpreactadminnet||[]).push([[0],{367:function(e,t,n){},425:function(e,t,n){},500:function(e,t,n){"use strict";n.r(t);var c=n(7),a=n(0),r=n.n(a),i=n(14),s=n.n(i),o=(n(367),n(20)),j=n(601),l=n(581),u=n(580),b=n(217),d=n.n(b),O=n(166),h=n(592),m=n(327),x=n(282),f="/admin/api/v1",p="/admin/api/v1/account/signIn",v="6LfYm5UaAAAAAEcv54Rhac9NXboKF9bFRyP53NcV",g=n(71);var w=Object(x.a)(f,(function(e){var t=arguments.length>1&&void 0!==arguments[1]?arguments[1]:{};t.headers||(t.headers=new Headers),t.headers.set("Accept","application/json");var n=localStorage.getItem("token"),c="Authorization";return t.headers.set(c,"Bearer ".concat(n)),g.a.fetchJson(e,t)})),S={login:function(e){var t=e.username,n=e.password,c=e.captchaResult,a=new Request(p,{method:"POST",body:JSON.stringify({username:t,password:n}),headers:new Headers({"Content-Type":"application/json",CaptchaResponse:c})});return fetch(a).then((function(e){if(e.status<200||e.status>=300)throw new Error("\u041d\u0435\u043f\u0440\u0430\u0432\u0438\u043b\u044c\u043d\u044b\u0439 \u043b\u043e\u0433\u0438\u043d \u0438\u043b\u0438 \u043f\u0430\u0440\u043e\u043b\u044c");return e.json()})).then((function(e){var t=e.data,n=t.accessToken,c=t.roles;C(n,c)}))},logout:function(){return P(),Promise.resolve()},checkError:function(e){var t=e.status;return 401===t||403===t?(P(),Promise.reject()):Promise.resolve()},checkAuth:function(){return y()?Promise.resolve():Promise.reject()},getPermissions:function(){var e=k();return e?Promise.resolve(JSON.parse(e)):Promise.resolve([])}},y=function(){return localStorage.getItem("token")},k=function(){return localStorage.getItem("permissions")},P=function(){localStorage.removeItem("token"),localStorage.removeItem("permissions")},C=function(e,t){localStorage.setItem("token",e),localStorage.setItem("permissions",JSON.stringify(t))},I=n(98),T=n(331),R=n(32),A=n(564),F=n(506),N=n(595),J=n(565),W=n(218),z=n(47),B=n(563),E=n(85),L=n(152),q=n(329),D=Object(W.a)((function(e){return{form:{padding:"0 1em 1em 1em"},input:{marginTop:"1em"},button:{width:"100%"},icon:{marginRight:e.spacing(1)}}}),{name:"RaLoginForm"}),H=function(e){var t=e.meta,n=t.touched,a=t.error,r=e.input,i=Object(T.a)(e,["meta","input"]);return Object(c.jsx)(N.a,Object(o.a)(Object(o.a)(Object(o.a)({error:!(!n||!a),helperText:n&&a},r),i),{},{fullWidth:!0}))},_=a.createRef(),V=function(e){var t=Object(z.a)(!1),n=Object(I.a)(t,2),a=n[0],r=n[1],i=Object(B.a)(),s=Object(E.a)(),o=Object(L.a)(),j=D(e);return Object(c.jsx)("div",{children:Object(c.jsx)(R.b,{onSubmit:function(e){r(!0),i(e).then((function(){r(!1)})).catch((function(e){r(!1),o("string"===typeof e?e:"undefined"!==typeof e&&e.message?e.message:"ra.auth.sign_in_error","warning")}))},validate:function(e){var t={username:void 0,password:void 0};return e.username||(t.username=s("ra.validation.required")),e.password||(t.password=s("ra.validation.required")),t},render:function(e){var t,n=e.handleSubmit;return Object(c.jsxs)("form",{onSubmit:function(e){e.preventDefault(),_.current.execute()},noValidate:!0,children:[Object(c.jsxs)("div",{className:j.form,children:[Object(c.jsx)("div",{className:j.input,children:Object(c.jsx)(R.a,{autoFocus:!0,id:"username",name:"username",component:H,label:s("ra.auth.username"),disabled:a})}),Object(c.jsx)("div",{className:j.input,children:Object(c.jsx)(R.a,{id:"password",name:"password",component:H,label:s("ra.auth.password"),type:"password",disabled:a,autoComplete:"current-password"})}),Object(c.jsx)(R.a,{name:"captchaResult",component:(t=function(){n(),_.current.reset()},function(e){return Object(c.jsx)(q.a,{ref:_,size:"invisible",sitekey:v,onChange:function(n){e.input.onChange(n),t()}})})})]}),Object(c.jsx)(A.a,{children:Object(c.jsxs)(F.a,{variant:"contained",type:"submit",color:"primary",disabled:a,className:j.button,children:[a&&Object(c.jsx)(J.a,{className:j.icon,size:18,thickness:2}),s("ra.auth.sign_in")]})})]})}})})},K=(n(425),n(288)),U=n.n(K),X=n(289),Y=n.n(X),G=Object(m.a)({palette:{primary:U.a,secondary:Y.a}}),M=n(566),Q=n(567),Z=n(219),$=n(52),ee=n(25),te=function(){return Object(c.jsxs)(M.a,{children:[Object(c.jsx)($.b,{title:"\u041d\u0435 \u043d\u0430\u0448\u043b\u043e\u0441\u044c"}),Object(c.jsxs)(Q.a,{children:[Object(c.jsx)("h1",{children:"\u041d\u0438\u0447\u0435\u0433\u043e \u043d\u0435 \u043d\u0430\u0448\u043b\u043e\u0441\u044c"}),Object(c.jsx)(Z.a,{children:Object(c.jsx)(ee.a,{to:"/vaccine",children:"\u043a \u0432\u0430\u043a\u0446\u0438\u043d\u0430\u043c"})}),Object(c.jsx)(Z.a,{children:Object(c.jsx)(ee.a,{to:"/diseas",children:"\u043a \u0431\u043e\u043b\u0435\u0437\u043d\u044f\u043c"})})]})]})},ne=n(588),ce=n(585),ae=n(599),re=n(298),ie=function(e){return Object(c.jsx)(ne.a,Object(o.a)(Object(o.a)({},e),{},{children:Object(c.jsx)(ce.a,{children:Object(c.jsx)(ae.a,{validate:Object(re.b)(),source:"name",fullWidth:!0,helperText:"\u0418\u043c\u044f \u043f\u0440\u0435\u043f\u043e\u0434\u0430\u0432\u0430\u0442\u0435\u043b\u044f",label:"\u0438\u043c\u044f"})})}))},se=n(584),oe=function(e){return Object(c.jsx)(se.a,Object(o.a)(Object(o.a)({},e),{},{undoable:!1,children:Object(c.jsx)(ce.a,{children:Object(c.jsx)(ae.a,{validate:Object(re.b)(),source:"name",fullWidth:!0,helperText:"\u0438\u043c\u044f \u043f\u0440\u0435\u043f\u043e\u0434\u0430\u0432\u0430\u0442\u0435\u043b\u044f",label:"\u0438\u043c\u044f"})})}))},je=n(591),le=n(582),ue=n(583),be=n(579),de=function(e){return Object(c.jsx)(je.a,Object(o.a)(Object(o.a)({},e),{},{children:Object(c.jsx)(ae.a,{label:"\u043f\u043e\u0438\u0441\u043a",source:"name"})}))},Oe=function(e){return Object(c.jsx)(le.a,Object(o.a)(Object(o.a)({},e),{},{filters:Object(c.jsx)(de,{}),title:"\u0421\u043f\u0438\u0441\u043e\u043a \u043f\u0440\u0435\u043f\u043e\u0434\u0430\u0432\u0430\u0442\u0435\u043b\u0435\u0439",children:Object(c.jsx)(ue.a,{rowClick:"edit",isRowSelectable:function(e){return!1},children:Object(c.jsx)(be.a,{source:"name",label:"\u0438\u043c\u044f"})})}))},he=n(328),me=n(594),xe=n(572),fe=function(e){return Object(c.jsx)(je.a,Object(o.a)(Object(o.a)({},e),{},{children:Object(c.jsx)(ae.a,{label:"\u043f\u043e\u0438\u0441\u043a",source:"name"})}))},pe=function(){var e=Object(a.useState)(!1),t=Object(I.a)(e,2),n=t[0],r=t[1],i=Object(a.useState)(!1),s=Object(I.a)(i,2),o=s[0],j=s[1],l=Object(a.useState)(""),u=Object(I.a)(l,2),b=u[0],d=u[1],O=Object(a.useState)(void 0),h=Object(I.a)(O,2),m=h[0],x=h[1];return Object(c.jsxs)(he.a,{children:[Object(c.jsx)(xe.a,{open:o,onClose:function(){return j(!1)},children:Object(c.jsxs)("div",{style:{padding:"20px"},children:[Object(c.jsx)("div",{children:"\u0412\u044b \u0443\u0441\u043f\u0435\u0448\u043d\u043e \u0437\u0430\u0433\u0440\u0443\u0437\u0438\u043b\u0438 \u0444\u0430\u0439\u043b!"}),Object(c.jsx)("div",{children:Object(c.jsx)(F.a,{onClick:function(){return j(!1)},children:"\u0417\u0430\u043a\u0440\u044b\u0442\u044c"})})]})}),Object(c.jsx)(xe.a,{open:n,onClose:function(){return r(!1)},children:Object(c.jsxs)("div",{style:{padding:"100px"},children:[Object(c.jsx)("div",{style:{color:"red"},children:b}),Object(c.jsx)("input",{type:"file",accept:".doc,.docx",onChange:function(e){var t=e.target.files;t&&x(t[0])}}),Object(c.jsx)("div",{style:{marginTop:"20px"},children:Object(c.jsx)(F.a,{onClick:function(){if(void 0!==m){var e=m.name.split(".");if(e.reverse(),"doc"===e[0]||"docx"===e[0]){d("");var t=new Headers;t.append("Authorization","Bearer "+(localStorage.getItem("token")||""));var n=new FormData;n.append("file",m),fetch("/admin/api/v1/subject/parse",{method:"POST",headers:t,body:n}).then((function(){r(!1),j(!0)}))}else d("\u0412\u044b\u0431\u0435\u0440\u0438\u0442\u0435 \u0444\u0430\u0439\u043b word")}else d("\u0412\u044b\u0431\u0435\u0440\u0438\u0442\u0435 \u0444\u0430\u0439\u043b")},children:"\u041e\u0442\u043f\u0440\u0430\u0432\u0438\u0442\u044c"})})]})}),Object(c.jsx)(F.a,{onClick:function(){return r(!0)},children:"\u0417\u0430\u0433\u0440\u0443\u0437\u0438\u0442\u044c \u0444\u0430\u0439\u043b"})]})},ve=function(e){return Object(c.jsx)(le.a,Object(o.a)(Object(o.a)({actions:Object(c.jsx)(pe,{})},e),{},{filters:Object(c.jsx)(fe,{}),title:"\u0421\u043f\u0438\u0441\u043e\u043a \u043f\u0440\u0435\u043f\u043e\u0434\u0430\u0432\u0430\u0442\u0435\u043b\u0435\u0439",children:Object(c.jsxs)(ue.a,{rowClick:"edit",isRowSelectable:function(e){return!1},children:[Object(c.jsx)(be.a,{source:"name",label:"\u0438\u043c\u044f"}),Object(c.jsx)(me.a,{label:"\u041f\u0440\u0435\u043f\u043e\u0434\u0430\u0432\u0430\u0442\u0435\u043b\u044c",reference:"teacher",source:"teacherId",children:Object(c.jsx)(be.a,{source:"name",label:"\u0438\u043c\u044f"})})]})}))},ge=n(586),we=n(587),Se=function(e){return Object(c.jsx)(ne.a,Object(o.a)(Object(o.a)({},e),{},{children:Object(c.jsxs)(ce.a,{children:[Object(c.jsx)(ae.a,{validate:Object(re.b)(),source:"name",fullWidth:!0,helperText:"\u043d\u0430\u0437\u0432\u0430\u043d\u0438\u0435 \u043f\u0440\u0435\u0434\u043c\u0435\u0442\u0430",label:"\u043d\u0430\u0437\u0432\u0430\u043d\u0438\u0435"}),Object(c.jsx)(ge.a,{label:"\u041f\u0440\u0435\u043f\u043e\u0434\u0430\u0432\u0430\u0442\u0435\u043b\u044c",reference:"teacher",source:"teacherId",children:Object(c.jsx)(we.a,{source:"name"})})]})}))},ye=function(e){return Object(c.jsx)(se.a,Object(o.a)(Object(o.a)({},e),{},{undoable:!1,children:Object(c.jsxs)(ce.a,{children:[Object(c.jsx)(ae.a,{validate:Object(re.b)(),source:"name",fullWidth:!0,helperText:"\u043d\u0430\u0437\u0432\u0430\u043d\u0438\u0435 \u043f\u0440\u0435\u0434\u043c\u0435\u0442\u0430",label:"\u043d\u0430\u0437\u0432\u0430\u043d\u0438\u0435"}),Object(c.jsx)(ge.a,{label:"\u041f\u0440\u0435\u043f\u043e\u0434\u0430\u0432\u0430\u0442\u0435\u043b\u044c",reference:"teacher",source:"teacherId",children:Object(c.jsx)(we.a,{source:"name"})})]})}))},ke=n(480),Pe=Object(O.a)((function(){return ke}),"ru"),Ce=Object(m.a)(),Ie=function(e){return Object(c.jsx)(j.a,Object(o.a)(Object(o.a)({},e),{},{children:Object(c.jsx)(r.a.Fragment,{children:Object(c.jsx)(V,Object(o.a)({},e))})}))};function Te(){return Object(c.jsx)(h.a,{theme:Ce,children:Object(c.jsxs)(l.a,{theme:G,dataProvider:w,catchAll:te,i18nProvider:Pe,authProvider:S,loginPage:Ie,children:[Object(c.jsx)(u.a,{name:"teacher",list:Oe,create:ie,edit:oe,icon:d.a,options:{label:"\u041f\u0440\u0435\u043f\u043e\u0434\u0430\u0432\u0430\u0442\u0435\u043b\u0438"}}),Object(c.jsx)(u.a,{name:"subject",list:ve,create:Se,edit:ye,icon:d.a,options:{label:"\u041f\u0440\u0435\u0434\u043c\u0435\u0442\u044b"}})]})})}var Re=function(e){e&&e instanceof Function&&n.e(3).then(n.bind(null,602)).then((function(t){var n=t.getCLS,c=t.getFID,a=t.getFCP,r=t.getLCP,i=t.getTTFB;n(e),c(e),a(e),r(e),i(e)}))};s.a.render(Object(c.jsx)(Te,{}),document.getElementById("root")),Re()}},[[500,1,2]]]);
//# sourceMappingURL=main.07355a87.chunk.js.map