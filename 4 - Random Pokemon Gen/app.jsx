const { useState, useEffect, useLayoutEffect, useMemo, useRef, forwardRef } = React;
const { Switch, Route, Redirect, useHistory, useLocation, useRouteMatch } = ReactRouterDOM;

const App = p =>
{
	const history = useHistory();
	const location = useLocation();

	const [pokemon, setPokemon] = useState("1");

	const Generate = () =>
	{
		const min = 1;
		const max = 500;
		setPokemon(Math.floor(Math.random() * (max - min) + min).toString());
	};

	return (
	<>
		<Rows marginSides="10%" minWidth={1000} paddingSides={16}>
			<Row>
				<Box><img src={`https://assets.pokemon.com/assets/cms2/img/pokedex/full/${pokemon.padStart(3, "0")}.png`}/></Box>
				<Button onClick={e => Generate()}>Generate</Button>
			</Row>
		</Rows>
	</>);
};