const { useState, useEffect, useLayoutEffect, useMemo, useRef, forwardRef } = React;
const { Switch, Route, Redirect, useHistory, useLocation, useRouteMatch } = ReactRouterDOM;

const App = p =>
{
	const history = useHistory();
	const location = useLocation();

	return (
	<>
		<Rows marginSides="10%" minWidth={1000} paddingSides={16}>
			<Row>
				The cow said moo.
			</Row>
		</Rows>
	</>);
};
