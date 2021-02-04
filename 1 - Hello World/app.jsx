const { useState, useEffect, useLayoutEffect, useMemo, useRef, forwardRef } = React;
const { Switch, Route, Redirect, useHistory, useLocation, useRouteMatch } = ReactRouterDOM;

const Moo = p =>
	<Box>
		<Box>{p.text}-{p.text2}</Box>
		<Box>{p.text}+{p.text2}</Box>
	</Box>;

const BigText = p =>
	<Box fontSize={32}>{p.children}</Box>;

const App = p =>
{
	const history = useHistory();
	const location = useLocation();

	return (
	<>
		<Rows marginSides="20%" minWidth={500} paddingSides={16}>
			<Row fg="#111">
				<Moo text="Pika!" text2="Chu!"/>
				<Moo text="Meow!" text2="Purr!"/>
				<BigText>Wheeee!</BigText>
			</Row>
		</Rows>
	</>);
};
