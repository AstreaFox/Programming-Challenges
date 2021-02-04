const { useState, useEffect, useLayoutEffect, useMemo, useRef, forwardRef } = React;
const { Switch, Route, Redirect, useHistory, useLocation, useRouteMatch } = ReactRouterDOM;

const App = p =>
{
	const history = useHistory();
	const location = useLocation();

	return (
	<>
		<Rows marginSides="20%" minWidth={500} paddingSides={16}>
			<Row>
				<Boxes textAlign="center" marginTop={20}>

					<Box><TextInput color="grey" label="First Name(s)"/></Box>
					<Box><TextInput color="grey" label="Last Name"/></Box>
					<Box><TextInput color="grey" label="Age"/></Box>
					<Box><Select color="grey"
						options={["Select Gender", "Male", "Female", "Other"]}/></Box>

				</Boxes>
			</Row>
		</Rows>
	</>);
};

