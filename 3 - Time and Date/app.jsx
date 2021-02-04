const { useState, useEffect, useLayoutEffect, useMemo, useRef, forwardRef } = React;
const { Switch, Route, Redirect, useHistory, useLocation, useRouteMatch } = ReactRouterDOM;

const App = p =>
{
	const history = useHistory();
	const location = useLocation();

	const [time, setTime] = useState();

	useEffect(() =>
	{
		setTime("");
		const timer = setInterval(() =>
			setTime(luxon.DateTime.local().toFormat("yyyy-MM-dd HH:mm:ss")), 1000);
		return () => clearInterval(timer);
	}, [location]);

	return (
	<>
		<Rows marginSides="10%" minWidth={1000} paddingSides={16}>
			<Row>
				<Box fontSize={24}>{time}</Box>
			</Row>
		</Rows>
	</>);
};
