const { useState, useEffect, useLayoutEffect, useMemo, useRef, forwardRef } = React;
const { Switch, Route, Redirect, useHistory, useLocation, useRouteMatch } = ReactRouterDOM;

const Moo = p =>
	<Box>
		<Box fontSize="12px" color="red">{p.children}</Box>
		<Box fontSize="12px" color="blue">{p.children}</Box>
	</Box>;

const App = p =>
{
	const history = useHistory();
	const location = useLocation();

	return (
	<>
		<Rows marginSides="20%" minWidth={500} paddingSides={16}>
			<Row>
				<Moo>Text goes here.</Moo>
				<Moo>Text goes here.</Moo>
			</Row>
		</Rows>
	</>);
};
