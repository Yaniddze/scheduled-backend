(this.webpackJsonpreactadminnet=this.webpackJsonpreactadminnet||[]).push([[0],{361:function(e,t,n){},419:function(e,t,n){},494:function(e,t,n){"use strict";n.r(t);var a=n(8),c=n(0),r=n.n(c),s=n(14),i=n.n(s),o=(n(361),n(20)),j=n(592),l=n(575),u=n(574),b=n(215),d=n.n(b),O=n(165),h=n(280),m="/admin/api/v1",f="/admin/api/v1/account/signIn",x="6LfYm5UaAAAAAEcv54Rhac9NXboKF9bFRyP53NcV",p=n(72);var v=Object(h.a)(m,(function(e){var t=arguments.length>1&&void 0!==arguments[1]?arguments[1]:{};t.headers||(t.headers=new Headers),t.headers.set("Accept","application/json");var n=localStorage.getItem("token"),a="Authorization";return t.headers.set(a,"Bearer ".concat(n)),p.a.fetchJson(e,t)})),g={login:function(e){var t=e.username,n=e.password,a=e.captchaResult,c=new Request(f,{method:"POST",body:JSON.stringify({username:t,password:n}),headers:new Headers({"Content-Type":"application/json",CaptchaResponse:a})});return fetch(c).then((function(e){if(e.status<200||e.status>=300)throw new Error("\u041d\u0435\u043f\u0440\u0430\u0432\u0438\u043b\u044c\u043d\u044b\u0439 \u043b\u043e\u0433\u0438\u043d \u0438\u043b\u0438 \u043f\u0430\u0440\u043e\u043b\u044c");return e.json()})).then((function(e){var t=e.data,n=t.accessToken,a=t.roles;y(n,a)}))},logout:function(){return P(),Promise.resolve()},checkError:function(e){var t=e.status;return 401===t||403===t?(P(),Promise.reject()):Promise.resolve()},checkAuth:function(){return w()?Promise.resolve():Promise.reject()},getPermissions:function(){var e=S();return e?Promise.resolve(JSON.parse(e)):Promise.resolve([])}},w=function(){return localStorage.getItem("token")},S=function(){return localStorage.getItem("permissions")},P=function(){localStorage.removeItem("token"),localStorage.removeItem("permissions")},y=function(e,t){localStorage.setItem("token",e),localStorage.setItem("permissions",JSON.stringify(t))},k=n(325),I=n(328),R=n(32),T=n(557),C=n(501),N=n(589),A=n(558),F=n(216),J=n(47),W=n(556),E=n(85),L=n(151),q=n(326),z=Object(F.a)((function(e){return{form:{padding:"0 1em 1em 1em"},input:{marginTop:"1em"},button:{width:"100%"},icon:{marginRight:e.spacing(1)}}}),{name:"RaLoginForm"}),B=function(e){var t=e.meta,n=t.touched,c=t.error,r=e.input,s=Object(I.a)(e,["meta","input"]);return Object(a.jsx)(N.a,Object(o.a)(Object(o.a)(Object(o.a)({error:!(!n||!c),helperText:n&&c},r),s),{},{fullWidth:!0}))},_=c.createRef(),D=function(e){var t=Object(J.a)(!1),n=Object(k.a)(t,2),c=n[0],r=n[1],s=Object(W.a)(),i=Object(E.a)(),o=Object(L.a)(),j=z(e);return Object(a.jsx)("div",{children:Object(a.jsx)(R.b,{onSubmit:function(e){r(!0),s(e).then((function(){r(!1)})).catch((function(e){r(!1),o("string"===typeof e?e:"undefined"!==typeof e&&e.message?e.message:"ra.auth.sign_in_error","warning")}))},validate:function(e){var t={username:void 0,password:void 0};return e.username||(t.username=i("ra.validation.required")),e.password||(t.password=i("ra.validation.required")),t},render:function(e){var t,n=e.handleSubmit;return Object(a.jsxs)("form",{onSubmit:function(e){e.preventDefault(),_.current.execute()},noValidate:!0,children:[Object(a.jsxs)("div",{className:j.form,children:[Object(a.jsx)("div",{className:j.input,children:Object(a.jsx)(R.a,{autoFocus:!0,id:"username",name:"username",component:B,label:i("ra.auth.username"),disabled:c})}),Object(a.jsx)("div",{className:j.input,children:Object(a.jsx)(R.a,{id:"password",name:"password",component:B,label:i("ra.auth.password"),type:"password",disabled:c,autoComplete:"current-password"})}),Object(a.jsx)(R.a,{name:"captchaResult",component:(t=function(){n(),_.current.reset()},function(e){return Object(a.jsx)(q.a,{ref:_,size:"invisible",sitekey:x,onChange:function(n){e.input.onChange(n),t()}})})})]}),Object(a.jsx)(T.a,{children:Object(a.jsxs)(C.a,{variant:"contained",type:"submit",color:"primary",disabled:c,className:j.button,children:[c&&Object(a.jsx)(A.a,{className:j.icon,size:18,thickness:2}),i("ra.auth.sign_in")]})})]})}})})},H=(n(419),n(286)),V=n.n(H),K=n(287),U=n.n(K),X=n(324),Y=Object(X.a)({palette:{primary:V.a,secondary:U.a}}),G=n(559),M=n(560),Q=n(217),Z=n(52),$=n(25),ee=function(){return Object(a.jsxs)(G.a,{children:[Object(a.jsx)(Z.b,{title:"\u041d\u0435 \u043d\u0430\u0448\u043b\u043e\u0441\u044c"}),Object(a.jsxs)(M.a,{children:[Object(a.jsx)("h1",{children:"\u041d\u0438\u0447\u0435\u0433\u043e \u043d\u0435 \u043d\u0430\u0448\u043b\u043e\u0441\u044c"}),Object(a.jsx)(Q.a,{children:Object(a.jsx)($.a,{to:"/vaccine",children:"\u043a \u0432\u0430\u043a\u0446\u0438\u043d\u0430\u043c"})}),Object(a.jsx)(Q.a,{children:Object(a.jsx)($.a,{to:"/diseas",children:"\u043a \u0431\u043e\u043b\u0435\u0437\u043d\u044f\u043c"})})]})]})},te=n(582),ne=n(578),ae=n(590),ce=n(295),re=function(e){return Object(a.jsx)(te.a,Object(o.a)(Object(o.a)({},e),{},{children:Object(a.jsx)(ne.a,{children:Object(a.jsx)(ae.a,{validate:Object(ce.b)(),source:"name",fullWidth:!0,helperText:"\u0418\u043c\u044f \u043f\u0440\u0435\u043f\u043e\u0434\u0430\u0432\u0430\u0442\u0435\u043b\u044f",label:"\u0438\u043c\u044f"})})}))},se=n(579),ie=function(e){return Object(a.jsx)(se.a,Object(o.a)(Object(o.a)({},e),{},{undoable:!1,children:Object(a.jsx)(ne.a,{children:Object(a.jsx)(ae.a,{validate:Object(ce.b)(),source:"name",fullWidth:!0,helperText:"\u0438\u043c\u044f \u043f\u0440\u0435\u043f\u043e\u0434\u0430\u0432\u0430\u0442\u0435\u043b\u044f",label:"\u0438\u043c\u044f"})})}))},oe=n(585),je=n(576),le=n(577),ue=n(572),be=function(e){return Object(a.jsx)(oe.a,Object(o.a)(Object(o.a)({},e),{},{children:Object(a.jsx)(ae.a,{label:"\u043f\u043e\u0438\u0441\u043a",source:"name"})}))},de=function(e){return Object(a.jsx)(je.a,Object(o.a)(Object(o.a)({},e),{},{filters:Object(a.jsx)(be,{}),title:"\u0421\u043f\u0438\u0441\u043e\u043a \u043f\u0440\u0435\u043f\u043e\u0434\u0430\u0432\u0430\u0442\u0435\u043b\u0435\u0439",children:Object(a.jsx)(le.a,{rowClick:"edit",isRowSelectable:function(e){return!1},children:Object(a.jsx)(ue.a,{source:"name",label:"\u0438\u043c\u044f"})})}))},Oe=n(588),he=function(e){return Object(a.jsx)(oe.a,Object(o.a)(Object(o.a)({},e),{},{children:Object(a.jsx)(ae.a,{label:"\u043f\u043e\u0438\u0441\u043a",source:"name"})}))},me=function(e){return Object(a.jsx)(je.a,Object(o.a)(Object(o.a)({},e),{},{filters:Object(a.jsx)(he,{}),title:"\u0421\u043f\u0438\u0441\u043e\u043a \u043f\u0440\u0435\u043f\u043e\u0434\u0430\u0432\u0430\u0442\u0435\u043b\u0435\u0439",children:Object(a.jsxs)(le.a,{rowClick:"edit",isRowSelectable:function(e){return!1},children:[Object(a.jsx)(ue.a,{source:"name",label:"\u0438\u043c\u044f"}),Object(a.jsx)(Oe.a,{label:"\u041f\u0440\u0435\u043f\u043e\u0434\u0430\u0432\u0430\u0442\u0435\u043b\u044c",reference:"teacher",source:"teacherId",children:Object(a.jsx)(ue.a,{source:"name",label:"\u0438\u043c\u044f"})})]})}))},fe=n(580),xe=n(581),pe=function(e){return Object(a.jsx)(te.a,Object(o.a)(Object(o.a)({},e),{},{children:Object(a.jsxs)(ne.a,{children:[Object(a.jsx)(ae.a,{validate:Object(ce.b)(),source:"name",fullWidth:!0,helperText:"\u043d\u0430\u0437\u0432\u0430\u043d\u0438\u0435 \u043f\u0440\u0435\u0434\u043c\u0435\u0442\u0430",label:"\u043d\u0430\u0437\u0432\u0430\u043d\u0438\u0435"}),Object(a.jsx)(fe.a,{label:"\u041f\u0440\u0435\u043f\u043e\u0434\u0430\u0432\u0430\u0442\u0435\u043b\u044c",reference:"teacher",source:"teacherId",children:Object(a.jsx)(xe.a,{source:"name"})})]})}))},ve=function(e){return Object(a.jsx)(se.a,Object(o.a)(Object(o.a)({},e),{},{undoable:!1,children:Object(a.jsxs)(ne.a,{children:[Object(a.jsx)(ae.a,{validate:Object(ce.b)(),source:"name",fullWidth:!0,helperText:"\u043d\u0430\u0437\u0432\u0430\u043d\u0438\u0435 \u043f\u0440\u0435\u0434\u043c\u0435\u0442\u0430",label:"\u043d\u0430\u0437\u0432\u0430\u043d\u0438\u0435"}),Object(a.jsx)(fe.a,{label:"\u041f\u0440\u0435\u043f\u043e\u0434\u0430\u0432\u0430\u0442\u0435\u043b\u044c",reference:"teacher",source:"teacherId",children:Object(a.jsx)(xe.a,{source:"name"})})]})}))},ge=n(474),we=Object(O.a)((function(){return ge}),"ru"),Se=function(e){return Object(a.jsx)(j.a,Object(o.a)(Object(o.a)({},e),{},{children:Object(a.jsx)(r.a.Fragment,{children:Object(a.jsx)(D,Object(o.a)({},e))})}))};function Pe(){return Object(a.jsxs)(l.a,{theme:Y,dataProvider:v,catchAll:ee,i18nProvider:we,authProvider:g,loginPage:Se,children:[Object(a.jsx)(u.a,{name:"teacher",list:de,create:re,edit:ie,icon:d.a,options:{label:"\u041f\u0440\u0435\u043f\u043e\u0434\u0430\u0432\u0430\u0442\u0435\u043b\u0438"}}),Object(a.jsx)(u.a,{name:"subject",list:me,create:pe,edit:ve,icon:d.a,options:{label:"\u041f\u0440\u0435\u0434\u043c\u0435\u0442\u044b"}})]})}var ye=function(e){e&&e instanceof Function&&n.e(3).then(n.bind(null,596)).then((function(t){var n=t.getCLS,a=t.getFID,c=t.getFCP,r=t.getLCP,s=t.getTTFB;n(e),a(e),c(e),r(e),s(e)}))};i.a.render(Object(a.jsx)(Pe,{}),document.getElementById("root")),ye()}},[[494,1,2]]]);
//# sourceMappingURL=main.b1fb7ca1.chunk.js.map